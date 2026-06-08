using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public Mon_D date;        // SO 데이터

    private float currenthp;           // 현재 체력
    private int currentdamage;       // 데미지
    private float detectRange = 5f;       //감지 범위
    private float attackRange = 1.5f;             // 사거리
    private float moveSpeed = 2f;                       //이속
    private float attackCooldown = 1.2f;           // 공속

    public Transform player;             // 플레이어 위치
    public Transform m_t;                // 몬스터의 transform
    [SerializeField] private Player_hp playerhp;
    private Animator anim;//애니매이션

    private void OnEnable()
    {
        StartCoroutine(InitMonsterSafe());
    }

    private IEnumerator InitMonsterSafe()
    {
        yield return new WaitForSeconds(4.3f);
        GameObject player = GameObject.FindWithTag("Player");
        if (player == null)
        {
            player = GameObject.Find("player");
        }

        if (player != null)
        {
            this.player = player.GetComponent<Transform>();
            playerhp = player.GetComponent<Player_hp>();
        }
    }
    private Vector3 originalScale;

    private void Start()
    {
        anim = GetComponent<Animator>();//애니매이션
        if (m_t == null) m_t = GetComponent<Transform>();

        if (m_t != null)
        {
            originalScale = m_t.localScale;
        }

        if (date != null)
        {
            currenthp = date._hp;  // 최대체력
            currentdamage = date._damage; // 데미지
            detectRange = date._detectRange; // 감지 범위
            attackCooldown = date._attackCooldown;  // 공속
            attackRange = date._attackRange;    // 사거리
            moveSpeed = date._moveSpeed;    // 이속
        }
    }

    public void AttackHP(int value)
    {
        currenthp -= value;
        Debug.Log("피격 받음" + currenthp);
        if (currenthp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        MoveToPlayer();
        if (player == null || m_t == null) return;

        float distance = Vector2.Distance(m_t.position, player.position);     // 거리계산

        if (distance <= attackRange)             // 공격
        {
            AttackPlayer();
        }
        else if (distance <= detectRange)           // 추적
        {
            MoveToPlayer();
        }
    }
    
    void MoveToPlayer()
    {
        if (player == null) return;

        Vector2 direction = (player.position - transform.position).normalized;
        transform.Translate(direction * moveSpeed * Time.deltaTime);
        if (direction.x > 0)
        {
            transform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.z);
        }
        else if (direction.x < 0)
        {
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
        }
    }

    void AttackPlayer()
    {
        if (canattack)
        {
                Player_hp.instance.Playerhp -= currentdamage;

            StartCoroutine(CoolTime());
        }
    }

    bool canattack = true;
    private IEnumerator CoolTime()
    {
        canattack = false;
        yield return new WaitForSeconds(attackCooldown);
        canattack = true;
    }

    private void OnDrawGizmosSelected() // 기즈모 색깔 표시(사거리,감지 범위)
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectRange); // 감지범위
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange); // 공격범위
    }
}
