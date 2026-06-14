using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story_1 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI story_1;
    [SerializeField] private Player data;
    private void Start()
    {
        StartCoroutine(Story());
    }
    private IEnumerator Story()
    {
        yield return new WaitForSeconds(4f);
        story_1.SetText($"???:멍청하긴 {data.p_name}.");
        yield return new WaitForSeconds(4f);
        story_1.SetText($"???:너가 준 이정보들만 있으면 난 널 해킹할수있다!");
        yield return new WaitForSeconds(4f);
        story_1.SetText($"3...");
        yield return new WaitForSeconds(2f);
        story_1.SetText($"2...");
        yield return new WaitForSeconds(2f);
        story_1.SetText($"1...!");
        yield return new WaitForSeconds(3f);
        story_1.SetText($"해킹 완료");
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(2);
    }
}
