using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquashNStretch : MonoBehaviour
{
    public float bobSpeed = 2f;
    public float bobHeight = 0.5f;
    public float squashAndStretchAmount = 0.1f;
    public float rotationAmount = 10f;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Bobbing motion
        float bob = Mathf.Sin(Time.time * bobSpeed) * bobHeight;
        Vector3 newPosition = transform.position;
        newPosition.y = originalScale.y + bob;
        transform.position = newPosition;

        // Squash and stretch
        float stretch = 1f - Mathf.Abs(bob) * squashAndStretchAmount;
        transform.localScale = new Vector3(originalScale.x, originalScale.y * stretch, originalScale.z);

        // Rotation
        float rotation = Mathf.Sin(Time.time * bobSpeed) * rotationAmount;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation);
    }
}
