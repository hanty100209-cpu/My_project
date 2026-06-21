using UnityEngine;

[CreateAssetMenu(fileName = "Save_Mon1", menuName = "Scriptable Objects/Save_Mon1")]
abstract public class Save_Mon1 : ScriptableObject
{
    public int _mhp = 15;
    public Vector2 trans;
    public bool live = true;
}
