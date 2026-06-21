using UnityEngine;

[CreateAssetMenu(fileName = "Save_data", menuName = "Save/Save_data")]
public class Save_data : ScriptableObject
{
    [Header("[ 플레이어 ]")]
    public Vector3 playerPosition = new Vector3(0, 0, 0);
    public int _hp = 100;

    [Header("[ 기능 해금도 ]")]
    public bool _canshift = false;
    public bool _candoublejump = false;
    public bool _sword1 = false;
    public bool _sword2 = false;
    public bool _cansee = false;

}
