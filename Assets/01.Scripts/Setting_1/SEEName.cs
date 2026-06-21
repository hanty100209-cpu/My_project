using UnityEngine;

public class SEEName : MonoBehaviour
{
    [SerializeField] private Save_data data;
    private void Start()
    {
        gameObject.SetActive(data._cansee);
    }
}
