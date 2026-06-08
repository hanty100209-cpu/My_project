using UnityEditor;
using UnityEngine;

public class Save_job : MonoBehaviour
{
    [SerializeField] private Pc_Save pc;
    [SerializeField] private GameObject _job1;
    [SerializeField] private GameObject _job2;
    public void Save()
    {
        pc._job1 = false;
        pc._job2 = true;
        EditorUtility.SetDirty(pc);
    }
}
