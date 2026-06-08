using UnityEditor;
using UnityEngine;

public class Reset_so : MonoBehaviour
{
    [SerializeField] private Mission m;
    [SerializeField] private Pc_Save pc;
    [SerializeField] private Save_data save;
    public void Re()
    {
        m.gravity = 1;
        pc._job1 = true;
        pc._job2 = true;
        save.playerPosition=new Vector3(0,0,0);
        save._canshift = false;
        save._candoublejump = false;
        EditorUtility.SetDirty(m);
        EditorUtility.SetDirty(pc);
        EditorUtility.SetDirty(save);
    }
    
}
