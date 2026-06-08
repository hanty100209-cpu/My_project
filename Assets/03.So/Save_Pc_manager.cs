using UnityEngine;

public class Save_Pc_manager : MonoBehaviour
{
    [SerializeField] private Pc_Save save_pc;

    [SerializeField] private GameObject _job1;
    [SerializeField] private GameObject _job2;
    private void Start()
    {
        _job1.SetActive(save_pc._job1);
        _job2.SetActive(save_pc._job2);
    }
}
