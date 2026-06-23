using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Save_job : MonoBehaviour
{
    [SerializeField] private Pc_Save pc;
    [SerializeField] private GameObject _job1;
    [SerializeField] private GameObject _job2;
    [SerializeField] private Player data;
    public TMP_InputField inputField;
    public void Save()
    {
        string inputText = inputField.text;
        if (int.TryParse(inputText, out int resultNumber))
        {
            if(data.year==resultNumber)
            {
                pc._job1 = false;
                pc._job2 = true;
#if UNITY_EDITOR
                EditorUtility.SetDirty(pc);
#endif
            }
        }
    }
}
