using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class VRTriggerLogger : MonoBehaviour
{
    public InputActionReference triggerAction; // Assign in Inspector

    private void Update()
    {
        if (triggerAction.action.WasPressedThisFrame())
        {
            Debug.Log("Trigger button pressed!");
        }
    }
}
