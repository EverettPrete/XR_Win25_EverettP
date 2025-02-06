using UnityEngine;

[RequireComponent (typeof(Collider))]

public class Log : MonoBehaviour
{
    [SerializeField] GameObject logOne;
    [SerializeField] GameObject logTwo;

    Collider m_collider = null;
    private void Awake()
    {
        m_collider = GetComponent<Collider>();
        m_collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {

        Blade blade = null;
        if (other.CompareTag("Blade"))
        {
            blade = other.GetComponentInParent<Blade>();
        }

        if (blade == null) return;
        if (blade.m_controllerDataReader == null) return;


        Split();

    }

    private void Split()
    {
     EnablePhysics(logOne);
     EnablePhysics(logTwo);
    }

    private void EnablePhysics(GameObject log)
    {
        Rigidbody rg = log.GetComponent<Rigidbody>();
        rg.useGravity = true;
        rg.isKinematic = false;
    }
}
