using System.Collections;
using UnityEngine;

public class Gravity_player : MonoBehaviour
{
    [SerializeField] private Mission mis;
    [SerializeField] private Rigidbody2D prb;
    private void Start()
    {
        Debug.Log(mis.gravity);
        StartCoroutine(UpGavity());
        prb.gravityScale = mis.gravity;

    }
    private IEnumerator UpGavity()
    {
        yield return new WaitForSeconds(5f);
        prb.gravityScale = 1;
    }
}
