using UnityEditor;
using UnityEngine;

public class Reset_so : MonoBehaviour
{
    [SerializeField] private Mission m;
    [SerializeField] private Pc_Save pc;
    [SerializeField] private Save_data save;
    [SerializeField] private Hidden hidden;
    public void Re()
    {
        hidden._heiden_ = false;
        m.gravity = 1;
        m.scale = 1.3f;
        m.b_Visible = false;
        m.warring_set = false;
        pc._job1 = true;
        pc._job2 = true;
        save.playerPosition=new Vector3(0,0,0);
        save._canshift = false;
        save._candoublejump = false;
        save._sword1 = false;
        save._sword2 = false;
        save._gun1 = false;
        EditorUtility.SetDirty(m);
        EditorUtility.SetDirty(pc);
        EditorUtility.SetDirty(save);
        EditorUtility.SetDirty(hidden);
    }
    
}
