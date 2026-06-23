using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_pc : MonoBehaviour
{
    public void PCExit()
    {
        Somanager.MoveToScene("Game_Start_frist");
    }
}
