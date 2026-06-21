using UnityEngine;
using UnityEngine.SceneManagement;

public class Hidden_End1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(4);
    }
}
