using UnityEditor;
using UnityEngine;

public class Get_trsh_sword : MonoBehaviour
{
    [SerializeField] private Save_data data;
    public void Getsword()
    {
        data._sword1 = true;
#if UNITY_EDITOR
        EditorUtility.SetDirty(data);
#endif
    }
}
