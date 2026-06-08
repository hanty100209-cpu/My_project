using Unity.VisualScripting;
using UnityEngine;

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
        //죽었을때
    }
}
