using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] private GameObject _h1;
    [SerializeField] private GameObject _h2;
    [SerializeField] private GameObject _h3;
    [SerializeField] private GameObject _h4;
    private void OnEnable()
    {
        _h1.SetActive(false);
        _h2.SetActive(false);
        _h3.SetActive(false);
        _h4.SetActive(false);
    }
}
