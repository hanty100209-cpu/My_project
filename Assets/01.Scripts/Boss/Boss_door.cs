using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss_door : MonoBehaviour
{
    [SerializeField] private Save_data save;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(save._sword2)
            {
                Somanager.MoveToScene("Nomal_End1 1");
            }
            else
            {
                Somanager.MoveToScene("Nomal_End1 2");
            }
        }

    }
}
