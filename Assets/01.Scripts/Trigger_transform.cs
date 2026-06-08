using UnityEngine;

public class Trigger_transform : MonoBehaviour
{
    [SerializeField] private Vector3 inputtrans;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.transform.position = inputtrans;
        }
    }
}
