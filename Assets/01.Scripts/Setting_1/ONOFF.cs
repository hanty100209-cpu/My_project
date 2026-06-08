using UnityEngine;

public class ONOFF : MonoBehaviour
{
    [SerializeField] private GameObject _object;//대상
    public void Set_true()
    {
        _object.SetActive(true);
    }
    public void Set_false()
    {
        _object.SetActive(false);
    }
}
