using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    public Transform characterTransform;
    public Transform cameraTransform; // Reference to the camera transform
    public float speed;

    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        // Get the forward and right vectors of the camera
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        forward.y = 0f; // Keep the direction in the XZ plane
        right.y = 0f;

        // Normalize the vectors to ensure consistent speed in all directions
        forward.Normalize();
        right.Normalize();

        if (Input.GetKey("up") || Input.GetKey(KeyCode.W))
        {
            moveDirection += forward;
        }
        if (Input.GetKey("down") || Input.GetKey(KeyCode.S))
        {
            moveDirection -= forward;
        }
        if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            moveDirection -= right;
        }
        if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            moveDirection += right;
        }

        // Normalize the movement direction to ensure consistent speed
        moveDirection.Normalize();

        // Apply the movement
        characterTransform.position += moveDirection * speed * Time.deltaTime;
    }
}
