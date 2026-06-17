using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StoryChat : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textname;
    [SerializeField] private TextMeshProUGUI _textsent;
    [SerializeField] private GameObject _textPanel;
    [SerializeField] private int _sentcount;
    [SerializeField] private Player _player;
    private int _count;
    [SerializeField] private string[] _name;
    [SerializeField] private string[] _sent;
    public void SetChat()
    {
        if (_count == _sentcount)
        {
            _textPanel.SetActive(false);
        }
        else
        {
            _textname.SetText(_name[_count]=="플레이어"?_player.p_name: _name[_count]);
            _textsent.SetText(_sent[_count]);
            _count++;
        }
    }
}
