using UnityEngine;

public class Save_Mon : MonoBehaviour
{
    [SerializeField] private Save_Mon1 data;
    private void Start()
    {
        transform.position = data.trans;

    }
}
