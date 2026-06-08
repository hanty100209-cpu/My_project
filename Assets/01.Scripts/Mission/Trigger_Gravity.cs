using UnityEngine;

public class Trigger_Gravity : MonoBehaviour
{
    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _rb.gravityScale = 1;
    }
}
