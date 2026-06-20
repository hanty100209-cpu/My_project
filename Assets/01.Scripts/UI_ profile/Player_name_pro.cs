using TMPro;
using UnityEngine;

public class Player_name_pro : MonoBehaviour
{
    [SerializeField] private Player ppp;
    [SerializeField] private TextMeshProUGUI text11;
    public int a;
    private void Start()
    {
        if(a==1)
        {
            text11.text = "이름:" + ppp.p_name;
        }
        if(a==2)
        {
            text11.text = ppp.year+" 년생";
        }
    }
}
