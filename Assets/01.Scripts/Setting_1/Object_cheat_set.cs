using UnityEngine;

public class Object_cheat_set : MonoBehaviour
{
    [SerializeField] private Mission m;
    private void Start()
    {
        transform.localScale = new Vector3(-m.scale,m.scale,m.scale);
    }
}
