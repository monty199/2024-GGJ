using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera newCamera;  // Assign the new camera in the Inspector
    private Camera previousCamera;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SwitchCamera(newCamera);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SwitchCamera(null);  // Deactivate the current camera when the player exits
        }
    }

    private void SwitchCamera(Camera newActiveCamera)
    {
        // Deactivate the previous camera
        if (previousCamera != null)
        {
            previousCamera.enabled = false;
        }

        // Activate the new camera
        if (newActiveCamera != null)
        {
            newActiveCamera.enabled = true;

            // Update the previous camera reference
            previousCamera = newActiveCamera;
        }
    }
}