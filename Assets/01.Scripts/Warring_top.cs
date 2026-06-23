using UnityEditor;
using UnityEngine;

public class Warring_top : MonoBehaviour
{
    [SerializeField] private Mission m;
    public void Ontri()
    {
        m.warring_set = true;
#if UNITY_EDITOR
        EditorUtility.SetDirty(m);
#endif
    }
    public void Offtri()
    {
        m.warring_set = false;
#if UNITY_EDITOR
        EditorUtility.SetDirty(m);
#endif
    }
}
