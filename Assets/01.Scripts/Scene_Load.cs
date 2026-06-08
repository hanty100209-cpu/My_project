using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Load : MonoBehaviour
{
    [SerializeField] private int load_Scene;
    public void Load()
    {
        SceneManager.LoadScene(load_Scene);
    }
}
