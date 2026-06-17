using UnityEngine;

public class Jump_map_triggger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.gameObject.transform.position = new Vector2(10, 1.5f);
        }
    }
}
