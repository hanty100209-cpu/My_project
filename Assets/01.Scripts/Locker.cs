using UnityEditor.Build.Content;
using UnityEngine;

public class Locker : MonoBehaviour
{
    [SerializeField] private GameObject _lock;
    private void OnMouseDown()
    {
        _lock.SetActive(true);
    }
}
