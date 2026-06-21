using System.Collections;
using UnityEngine;

public class Ending : MonoBehaviour
{
    [SerializeField] private GameObject scene1;
    [SerializeField] private GameObject scene2;
    [SerializeField] private GameObject scene3;
    [SerializeField] private GameObject scene4;
    private void Start()
    {
        scene1.SetActive(true);
        StartCoroutine(St());
    }
    private IEnumerator St()
    {
        yield return new WaitForSeconds(5f);
        scene1.SetActive(false);
        scene2.SetActive(true);
        yield return new WaitForSeconds(5f);
        scene2.SetActive(false);
        scene3.SetActive(true);
        yield return new WaitForSeconds(5f);
        scene3.SetActive(false);
        scene4.SetActive(true);
    }
}
