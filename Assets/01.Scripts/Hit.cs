using System.Collections;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private Monster mon;
    [SerializeField] private int damage = 3;
    private void OnEnable()
    {
        StartCoroutine(Fal());
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Mon"))
        {
            if(collision.gameObject.TryGetComponent<Monster>(out Monster mon))
            {
                mon.MonHP(damage);
                gameObject.SetActive(false);
            }
        }
    }
    private IEnumerator Fal()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}