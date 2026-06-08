using TMPro;
using UnityEditor;
using UnityEngine;

public class Name : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] private Player so;

    public void InputData()
    {
        string inputText = inputField.text;
        if (inputText!=null)
        {
            so.p_name = inputText;
            EditorUtility.SetDirty(so);
        }
        else
        {
            Debug.Log("플레이어 등록 불가");
        }
    }
}
