using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_hp : MonoBehaviour
{
    public static Player_hp instance;
    [field:SerializeField] public int Playerhp { get; set; } = 100;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if(Playerhp<=0)
        {
            Die();
        }
    }
    public void Die()
    {
        SceneManager.LoadScene("Title_Scene");
    }
}
