using UnityEngine;

public class SO : ScriptableObject
{
    // 각 SO마다 고유한 저장 키를 만들기 위해 자기 자신의 이름을 사용합니다.
    private string SaveKey => "SO_Save_" + name;

    /// <summary>
    /// 이 SO의 모든 데이터를 기기에 한 방에 저장합니다.
    /// </summary>
    public void SaveGameData()
    {
        // 내 내부 데이터를 JSON 문자열로 변환
        string json = JsonUtility.ToJson(this);
        // 기기에 저장
        PlayerPrefs.SetString(SaveKey, json);
        PlayerPrefs.Save();
    }

    /// <summary>
    /// 기기에 저장된 데이터를 이 SO에 한 방에 불러옵니다.
    /// </summary>
    public void LoadGameData()
    {
        if (PlayerPrefs.HasKey(SaveKey))
        {
            string json = PlayerPrefs.GetString(SaveKey);
            // 저장된 JSON 데이터를 내 변수들에 덮어씌움
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
}
