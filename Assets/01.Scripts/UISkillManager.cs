using UnityEngine;

public class UISkillManager : MonoBehaviour
{
    [SerializeField] private GameObject q1;
    public bool _unlockjump {  get; set; } = false;
    public static UISkillManager instance;
    private void Awake()
    {
        instance = this;
    }
    public void Get()
    {
        _unlockjump = true;
        q1.SetActive(false);
    }
}
