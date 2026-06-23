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
        story_1.SetText($"???:어리석긴 {data.p_name}.");
        yield return new WaitForSeconds(4f);
        story_1.SetText($"???:너도 이제 끝이다");
        yield return new WaitForSeconds(3f);
        story_1.SetText($"???:3...");
        yield return new WaitForSeconds(1.5f);
        story_1.SetText($"???:2...");
        yield return new WaitForSeconds(1.5f);
        story_1.SetText($"???:1...!");
        yield return new WaitForSeconds(1.5f);
        story_1.SetText($"(어디론가 떨어지는 것이 느껴진다)");
        yield return new WaitForSeconds(2f);
        Somanager.MoveToScene("Game_Start_frist");
    }
}
