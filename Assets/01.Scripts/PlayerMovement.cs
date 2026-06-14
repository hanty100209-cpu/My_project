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
    private Animator anim;
    private Vector3 oriscale;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _onpc_b.SetActive(false);
        anim = GetComponent<Animator>();
    }
    private void Start()
    {
        oriscale = transform.localScale;
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
                    anim.SetBool("Shift", false);
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
        if (anim != null)
        {
            anim.SetBool("Move", _moveDir != Vector2.zero ? true : false);
        }
        if (_moveDir.x > 0)
        {
            transform.localScale = new Vector3(-oriscale.x, oriscale.y, oriscale.z);
        }
        else if (_moveDir.x < 0)
        {
            transform.localScale = new Vector3(oriscale.x, oriscale.y, oriscale.z);
        }
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
            anim.SetBool("Jump",true);
        }
    }//점프
    
    private IEnumerator Shift()
    {
        if (anim != null)
        {
            anim.SetBool("Shift", true);
        }
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
            anim.SetBool("Jump", false);
        }
        
    }
}