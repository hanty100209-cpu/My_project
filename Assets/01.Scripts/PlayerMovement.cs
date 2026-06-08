using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed = 8f;
    [SerializeField] private float _jumpForce = 2f;
    [SerializeField] private Q2 _q2;
    private Vector2 _shiftposition;
    private Vector2 _moveDir;
    private bool _isfloor = true;
    public bool _isshift = false;
    [SerializeField] private GameObject _onpc_b;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _onpc_b.SetActive(false);
    }

    private void Update()
    {
        if (UISkillManager.instance._unlockjump && _isfloor)
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Jump();
            }
        }//점프
        if (_q2._unlockshift)
        {
            if (Keyboard.current.leftShiftKey.wasPressedThisFrame)
            {
                if (_isshift)
                {
                    _isshift = false;
                    _onpc_b.SetActive(false);
                }
                else if(!_isshift&&_isfloor)
                {
                    _isshift = true;
                    StartCoroutine(Shift());
                }
            }
        }//shift
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = new Vector2(_moveDir.x * _speed, _rb.linearVelocity.y);
    }
    public void OnMove(InputValue value)
    {
        _moveDir = value.Get<Vector2>();
    }
    public void Jump()
    {
        if (_isfloor && UISkillManager.instance._unlockjump)
        {
            _isfloor = false;
            _rb.linearVelocityY = _jumpForce;
        }
    }//점프
    
    private IEnumerator Shift()
    {
        _shiftposition = transform.position;
        _onpc_b.SetActive(true);
        while (_isshift)
        {
            transform.position = _shiftposition;
            yield return null;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            _isfloor = true;
        }
        
    }
}