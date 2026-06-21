using UnityEngine;

public class OOO_See : MonoBehaviour
{
    [SerializeField] private Save_data sa;
    public void See()
    {
        sa._cansee = true;
    }
}
