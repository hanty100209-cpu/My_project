using UnityEditor.Rendering;
using UnityEngine;

public class Starat_set : MonoBehaviour
{
    [SerializeField] private Hidden hh;
    private void Start()
    {
        gameObject.SetActive(hh._heiden_);
    }
}
