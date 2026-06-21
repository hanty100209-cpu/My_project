using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private int a;
    public void Scn()
    {
        SceneManager.LoadScene(a);
    }
}
