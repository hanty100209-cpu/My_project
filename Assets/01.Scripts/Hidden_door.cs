using UnityEditor;
using UnityEngine;

public class Hidden_door : MonoBehaviour
{
    [SerializeField] private Hidden hh;
    public void Hidden1()
    {
        hh._heiden_ = true;
        EditorUtility.SetDirty(hh);
    }
}
