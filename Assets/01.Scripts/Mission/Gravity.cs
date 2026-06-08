using TMPro;
using UnityEditor;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] private Mission m;

    public void InputNumber()
    {
        string inputText = inputField.text;
        if (float.TryParse(inputText, out float resultNumber))
        {
            m.gravity = resultNumber;
            EditorUtility.SetDirty(m);
        }
        else
        {
            Debug.Log("입력된 값이 없거나 올바른 숫자가 아닙니다.");
        }
    }
}

