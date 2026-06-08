using UnityEngine;

[CreateAssetMenu(fileName = "Mon_D", menuName = "Mon_D/Mon_D")]
abstract public class Mon_D : ScriptableObject
{
    public int _hp;
    public int _damage;
    public float _detectRange;
    public float _attackCooldown;
    public float _attackRange;
    public float _moveSpeed;
}
