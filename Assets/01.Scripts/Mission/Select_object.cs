using TMPro;
using UnityEditor;
using UnityEngine;

public class Select_object : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] private Mission m;

    public void InputNumber()
    {
        string inputText = inputField.text;
        if (float.TryParse(inputText, out float resultNumber))
        {
            m.scale = resultNumber;
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
