using UnityEngine;

public class TowerOOP : Enemy
{
    [SerializeField] private Transform m_playerTarget;
    [SerializeField] private float m_attackRate = 3f;
    [SerializeField] private float m_attackRange = 0.5f;
    [SerializeField] private int m_attackDamage = 1;
    
    [SerializeField] private float m_moveSpeed = 0.5f;
    [SerializeField] private Projectile m_projectilePrefab;
    [field: SerializeField] public string Name { get; protected set; }

    private Coroutine attackCoroutine;

    private bool IsWithinAttackRange => Vector3.Distance(transform.position, m_playerTarget.position) < m_attackRange;


    
    private void AimTorret(Transform target)
    {
        // Get the direction from the object to the player
        Vector3 direction = m_playerTarget.position - transform.position;

        // Zero out the Y component to prevent rotation on the vertical axis
        direction.y = 0;

        if (direction != Vector3.zero)
        {
            // Create a rotation towards the target while ignoring vertical rotation
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = targetRotation;
        }
    }

    //private void Fire()
    //{
    //    Projectile projectile = Instantiate(m_projectilePrefab, m_torret.position, m_torret.rotation);
    //    projectile.Shoot(m_attackDamage);
    //}

}
