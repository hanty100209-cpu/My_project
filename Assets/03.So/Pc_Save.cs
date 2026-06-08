using UnityEngine;

[CreateAssetMenu(fileName = "Pc_Save", menuName = "Save/Pc_Save")]
public class Pc_Save : ScriptableObject
{
    [Header("[ 현재 작업 ]")]
    public bool _job1 = true;
    public bool _job2 = false;
}
