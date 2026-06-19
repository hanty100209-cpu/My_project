using UnityEditor;
using UnityEngine;

public class Warring_top : MonoBehaviour
{
    [SerializeField] private Mission m;
    public void Ontri()
    {
        m.warring_set = true;
        EditorUtility.SetDirty(m);
    }
    public void Offtri()
    {
        m.warring_set = false;
        EditorUtility.SetDirty(m);
    }
}
