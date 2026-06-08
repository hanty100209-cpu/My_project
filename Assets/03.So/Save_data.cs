using UnityEngine;

[CreateAssetMenu(fileName = "Save_data", menuName = "Save/Save_data")]
public class Save_data : ScriptableObject
{
    [Header("[ 플레이어 위치 ]")]
    public Vector3 playerPosition = new Vector3(0, 0, 0);

    [Header("[ 기능 해금도 ]")]
    public bool _canshift = false;
    public bool _candoublejump = false;
    public bool _sword = false;
    public bool _gun1 = false;
}
