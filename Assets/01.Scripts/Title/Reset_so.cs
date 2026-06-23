using UnityEditor;
using UnityEngine;

public class Reset_so : MonoBehaviour
{
    [SerializeField] private Mission m;
    [SerializeField] private Pc_Save pc;
    [SerializeField] private Save_data save;
    [SerializeField] private Hidden hidden;
    [SerializeField] private Mon1 h1;
    [SerializeField] private Mon2 h2;
    [SerializeField] private Mon3 h3;
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
        save._hp = 100;
        h1.live = true;
        h1._mhp = 15;
        h1.trans = new Vector2(100,4);
        h2.live = true;
        h2._mhp = 15;
        h2.trans = new Vector2(130,4);
        h3.live = true;
        h3._mhp = 15;
        h3.trans = new Vector2(180,4);
#if UNITY_EDITOR
        EditorUtility.SetDirty(h1);

        EditorUtility.SetDirty(h2);
        EditorUtility.SetDirty(h3);
        EditorUtility.SetDirty(m);
        EditorUtility.SetDirty(pc);
        EditorUtility.SetDirty(save);
        EditorUtility.SetDirty(hidden);
#endif
    }

}
