using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Year : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] private Player so;
    string inputText;
    public void InputData()
    {
        if (string.IsNullOrWhiteSpace(inputField.text)) return;

        if (int.TryParse(inputField.text, out int result))
        {
            so.year = result;
#if UNITY_EDITOR
            EditorUtility.SetDirty(so);
#endif
        }
        if (so.p_name != null)
        {
            gameObject.SetActive(false);
            Somanager.MoveToScene("Start_story");
        }
    }
}
