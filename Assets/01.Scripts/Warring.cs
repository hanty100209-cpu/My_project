using UnityEngine;

public class Warring : MonoBehaviour
{
    [SerializeField] private Mission m;
    [SerializeField] BoxCollider2D boxcoll;
    private void Start()
    {
        boxcoll.isTrigger = m.warring_set;
    }
    
}
