using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    [SerializeField] private Player p;
    [SerializeField] private Slider s;
    private void Start()
    {
        s.value = p.sound;
    }
}
