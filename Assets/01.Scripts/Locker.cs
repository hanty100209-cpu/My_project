using UnityEditor.Build.Content;
using UnityEngine;

public class Locker : MonoBehaviour
{
    [SerializeField] private GameObject _lock;
    public void OnLock()
    {
        _lock.SetActive(true);
    }
}
