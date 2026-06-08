using TMPro;
using UnityEngine;

public class Password : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] private GameObject nextJob;
    [SerializeField] private GameObject isJob;
    [SerializeField] private int want_input;
    public void InputNumber()
    {
        string inputText = inputField.text;
        if (int.TryParse(inputText, out int resultNumber))
        {
            if(nextJob!=null&&isJob!=null)
            {
                if (resultNumber == want_input)
                {
                    Debug.Log("Yes_Password");
                    nextJob.SetActive(true);
                    isJob.SetActive(false);
                }
                else
                {
                    Debug.Log("NO_Password");
                }
            }
            if(want_input==15483)
            {
                if (resultNumber == want_input)
                {
                    nextJob.SetActive(true);
                }
                else
                {
                    Debug.Log("NO_Password");
                }
            }

        }
        else
        {
            Debug.LogWarning("입력된 값이 없거나 올바른 숫자가 아닙니다.");
        }
    }
}
