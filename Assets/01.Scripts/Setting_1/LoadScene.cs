using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private int a;
    public void Scn()
    {
        Somanager.MoveToScene("Title_Scene");
    }
}
