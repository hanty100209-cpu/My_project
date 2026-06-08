using UnityEngine;

public class Q2 : MonoBehaviour
{
    [SerializeField] private GameObject q1;
    public bool _unlockshift = false;

    public void Get()
    {
        _unlockshift = true;
        q1.SetActive(false);
    }
}
