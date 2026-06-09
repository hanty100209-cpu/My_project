using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Story : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textname;
    [SerializeField] private TextMeshProUGUI _textsent;
    [SerializeField] private GameObject _textPanel;
    [SerializeField] private int _sentcount;
    private int _count;

    [SerializeField] private string[] _name;
    [SerializeField] private string[] _sent;
    private void Start()
    {
        SetChat();
    }

    public void SetChat()
    {
        if (_count == _sentcount)
        {
            _textPanel.SetActive(false);
        }
        else
        {
            _textname.SetText(_name[_count]);
            _textsent.SetText(_sent[_count]);
            _count++;
        }
    }
}
