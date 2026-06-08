using UnityEngine;
using UnityEngine.SceneManagement;

public class Title_B : MonoBehaviour
{
    public void B_Start()
    {
        SceneManager.LoadScene(1);
    }
    public void Eixt()
    {
        Debug.Log("게임 종료");
    }
}
