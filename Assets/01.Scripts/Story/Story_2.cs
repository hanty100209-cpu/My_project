using System.Collections;
using UnityEngine;

public class Story_2 : MonoBehaviour
{
    [SerializeField] private GameObject _story_2;
    private void Start()
    {
        StartCoroutine(Story());
    }
    private IEnumerator Story()
    {
        yield return new WaitForSeconds(2);
        _story_2.SetActive(true);
    }
}
