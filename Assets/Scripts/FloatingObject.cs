using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float moveSpeed = 2f; // Speed of the floating movement
    public float floatHeight = 1f; // Height of the floating movement

    private Vector3 initialPosition;

    void Start()
    {
        // Save the initial position for reference
        initialPosition = transform.position;
    }

    void Update()
    {
        // Calculate the vertical movement using a sine wave
        float verticalMovement = Mathf.Sin(Time.time * moveSpeed) * floatHeight;

        // Update the object's position
        transform.position = new Vector3(initialPosition.x, initialPosition.y + verticalMovement, initialPosition.z);
    }
}