using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_hp : MonoBehaviour
{
    public static Player_hp instance;
    [field:SerializeField] public int Playerhp { get; set; } = 100;
    [SerializeField] private Slider _bar;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        _bar.value = Playerhp / 100f;
        if (Playerhp<=0)
        {
            Die();
        }
    }
    public void Die()
    {
        SceneManager.LoadScene("Title_Scene");
    }
}
