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
            if(-5<=resultNumber&&10>=resultNumber)
            m.gravity = resultNumber;
#if UNITY_EDITOR
            EditorUtility.SetDirty(m);
#endif
        }
        else
        {
            Debug.Log("입력된 값이 없거나 올바른 숫자가 아닙니다.");
        }
    }
}

