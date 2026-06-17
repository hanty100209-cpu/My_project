using TMPro;
using UnityEngine;

public class Password : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] private GameObject nextJob;
    [SerializeField] private GameObject isJob;
    [SerializeField] private int want_input;
    [SerializeField] private Player data;
    [SerializeField] private GameObject want_1;
    [SerializeField] private GameObject want_2;
    private GameObject current_job;
    public void InputNumber()
    {
        string inputText = inputField.text;
        if (int.TryParse(inputText, out int resultNumber))
        {
            if(nextJob!=null&&isJob!=null&&data!=null)
            {
                if (resultNumber == data.year)
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
            if(want_input==117)
            {
                if (resultNumber == want_input)
                {
                    nextJob.SetActive(true);
                    isJob.SetActive(false);
                }
                else
                {
                    Debug.Log("NO_Password");
                }
            }

        }
        else
        {
            
        }
        
    }
    public void InputString()
    {
        if (inputField.text != null)
        {
            if ("사이버 빌딩" == inputField.text)
            {
                want_1.SetActive(true);
                if (current_job != null)
                {
                    current_job.SetActive(false);
                }
                current_job = want_1;
            }
            if ("404" == inputField.text)
            {
                want_2.SetActive(true);
                if (current_job != null)
                {
                    current_job.SetActive(false);
                }
                current_job = want_2;
            }
        }
    }
}
