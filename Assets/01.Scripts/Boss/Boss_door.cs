using UnityEngine;

public class Boss_door : MonoBehaviour
{
    [SerializeField] private Vector2 tran;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.transform.position= tran;
        }
    }
}
