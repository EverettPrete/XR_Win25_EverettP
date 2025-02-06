using UnityEngine;

public class ObjectPuller : MonoBehaviour
{
    public Transform target; // The object to pull towards
    public float speed = 5f; // Movement speed
    public bool shouldPull = false; // Toggle pulling via Inspector

    void Update()
    {
        if (shouldPull && target != null)
        {
            // Move towards the target
            transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);

            // Stop moving when close enough
            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                shouldPull = false; // Stop moving
            }
        }
    }

    // Call this method to start pulling via script
    public void StartPulling()
    {
        shouldPull = true;
    }
}
