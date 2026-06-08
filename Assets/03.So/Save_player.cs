using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Save_player : MonoBehaviour
{
    [SerializeField] private Save_data save;
    [SerializeField] private Q2 _q2;
    [SerializeField] private Rigidbody2D prb;
    [SerializeField] private Mission mis;

    private void Start()
    {
        transform.position = save.playerPosition;
        _q2._unlockshift = save._canshift;
        UISkillManager.instance._unlockjump = save._candoublejump;
        StartCoroutine(Gavity());
    }
    private void Update()
    {
        if(Keyboard.current.shiftKey.wasPressedThisFrame)
        {
            save.playerPosition = transform.position;
            save._canshift = _q2._unlockshift;
            save._candoublejump = UISkillManager.instance._unlockjump;
            EditorUtility.SetDirty(save);
        }
    }
    private IEnumerator Gavity()
    {
        yield return new WaitForSeconds(0.5f);
        prb.gravityScale = mis.gravity;
        yield return new WaitForSeconds(4f);
        prb.gravityScale = 1;
    }
}
