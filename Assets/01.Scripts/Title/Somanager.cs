using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Somanager : MonoBehaviour
{
    private static Somanager instance;

    [Header("[ 자동 저장/로드할 모든 SO를 아래 리스트에 넣어주세요 ]")]
    [SerializeField] private List<SO> soList = new List<SO>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // 씬이 켜지면 리스트에 있는 모든 SO를 자동으로 로드
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        foreach (var so in soList)
        {
            if (so != null)
            {
                so.LoadGameData();
            }
        }
        Debug.Log($"{scene.name} 씬 로드: 모든 SO 데이터를 불러왔습니다.");
    }

    // 다음 씬으로 넘어가기 직전에 리스트에 있는 모든 SO를 자동으로 저장
    public static void MoveToScene(string sceneName)
    {
        if (instance != null)
        {
            foreach (var so in instance.soList)
            {
                if (so != null)
                {
                    so.SaveGameData();
                }
            }
            Debug.Log("씬 이동 직전: 모든 SO 데이터를 저장했습니다.");
        }

        SceneManager.LoadScene(sceneName);
    }
}
