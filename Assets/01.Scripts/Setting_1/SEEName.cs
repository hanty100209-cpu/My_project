using UnityEngine;

public class SEEName : MonoBehaviour
{
    [SerializeField] private Save_data data;
    private void Start()
    {
        if(data._cansee)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
