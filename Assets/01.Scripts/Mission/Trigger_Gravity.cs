using UnityEngine;

public class Trigger_Gravity : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private Mission save;
    private void Awake()
    {
        _rb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            _rb.gravityScale = 1;
            save.gravity = 1;
        }
    }
}
