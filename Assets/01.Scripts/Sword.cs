using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] private int damage = 10;//데미지

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Monster monster = collision.GetComponent<Monster>();

        if (monster != null)
        {
            monster.AttackHP(damage);
        }
    }
}