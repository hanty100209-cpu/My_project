using UnityEngine;

public class ON : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    public void Down()
    {
        _object.SetActive(false);
    }
}
