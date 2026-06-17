using UnityEngine;

public class Q3 : MonoBehaviour
{
    [SerializeField] private GameObject q1;
    [SerializeField] private Save_data p1;

    public void Get()
    {
        q1.SetActive(false);
        p1._sword2 = true;
    }
}
