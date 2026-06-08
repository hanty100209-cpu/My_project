using UnityEngine;

public class UISetactive : MonoBehaviour
{
    private GameObject _player;
    [SerializeField]private GameObject _ui;//활성화/비활성화 할 ui
    private float _range = 3; // 비/활성화 거리

    private void OnEnable()
    {
        _player = GameObject.Find("Player");
    }
    private void Update()
    {
        float dis = Vector2.Distance(transform.position,_player.transform.position);//거리계산
        if(dis<=_range)
        {
            _ui.SetActive(true);
        }
        else
        {
            _ui.SetActive(false);
        }
    }
}
