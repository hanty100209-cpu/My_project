using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_hp : MonoBehaviour
{
    public static Player_hp instance;
    [field:SerializeField] public int Playerhp { get; set; } = 100;
    [SerializeField] private Slider _bar;
    [SerializeField] private Save_data data;
    [SerializeField] private GameObject _die;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        Time.timeScale = 1;
        data._hp = Playerhp;
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
        _die.SetActive(true);
        Time.timeScale = 0;
    }
}
