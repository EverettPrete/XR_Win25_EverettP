using UnityEngine;

public class SlimeOOP : Enemy
{
    [SerializeField] private Transform m_playerTarget;
    [SerializeField] private float m_attackRate = 3f;
    [SerializeField] private float m_attackRange = 0.5f;
    [SerializeField] private int m_attackDamage = 1;

    [SerializeField] private float m_moveSpeed = 0.5f;

    [field: SerializeField] public string Name { get; protected set; }

    private Coroutine attackCoroutine;

    private bool IsWithinAttackRange => Vector3.Distance(transform.position, m_playerTarget.position) < m_attackRange;

    protected override void Attack()
    {
        base.Attack();
    }



}
