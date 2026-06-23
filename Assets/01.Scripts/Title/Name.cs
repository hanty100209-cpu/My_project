using TMPro;
using UnityEngine;

public class Name : MonoBehaviour
{
    public TMP_InputField inputField;
    [SerializeField] private Player so;
    [SerializeField] private GameObject ne;

    public void InputData()
    {
        // ⭐ 핵심: 인풋 필드에 입력된 텍스트를 가져옵니다. 
        // string.IsNullOrWhiteSpace를 쓰면 띄어쓰기만 입력하는 것도 막아줍니다.
        if (!string.IsNullOrWhiteSpace(inputField.text))
        {
            // 인풋 필드의 글자를 SO의 p_name에 바로 저장합니다.
            so.p_name = inputField.text;

#if UNITY_EDITOR
            // 에디터 변경 사항 기록 (using UnityEditor 없이 사용하는 방식)
            UnityEditor.EditorUtility.SetDirty(so);
#endif
        }
        else
        {
            Debug.Log("플레이어 등록 불가 (이름이 비어있음)");
            return; // 이름이 비어있으면 아래 코드를 실행하지 않고 중단합니다.
        }

        // 이름이 정상적으로 들어갔다면 다음 오브젝트를 켭니다.
        if (!string.IsNullOrEmpty(so.p_name))
        {
            gameObject.SetActive(false);
            ne.SetActive(true);
        }
    }
}