using System.Collections;
using UnityEngine;

public class Story_2 : MonoBehaviour
{
    [SerializeField] private GameObject _story_2;
    [SerializeField] private StoryChat _chat;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            StartCoroutine(Story());
        }
        
    }
    private IEnumerator Story()
    {
        yield return new WaitForSeconds(0.8f);
        _story_2.SetActive(true);
        _chat.SetChat();
    }
}
