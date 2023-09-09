using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTankMovement : MonoBehaviour
{
    public Joystick joystick;
    public float rotatesens;

    public float runSpeed = 10f;
    float horizontalMove = 0f;
    float verticalMove = 0f;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Get the horizontal and vertical input from the joystick.
        float horizontalInput = joystick.Horizontal;
        float verticalInput = joystick.Vertical;

        // Check if the joystick input is outside a dead zone for horizontal movement.
        if (Mathf.Abs(horizontalInput) >= 0.4f)
        {
            // Set the horizontal move value based on the input.
            horizontalMove = horizontalInput * rotatesens;
        }
        else
        {
            // If the input is within the dead zone, stop moving horizontally.
            horizontalMove = 0f;
        }

        // Check if the joystick input is outside a dead zone for vertical movement.
        if (Mathf.Abs(verticalInput) >= 0.4f)
        {
            // Set the vertical move value based on the input.
            verticalMove = verticalInput * runSpeed;
        }
        else
        {
            // If the input is within the dead zone, stop moving vertically.
            verticalMove = 0f;
        }
    }

    private void FixedUpdate()
    {
        // Calculate the movement direction based on the tank's rotation.
        Vector3 movementDirection = transform.forward * verticalMove;

        // Apply the movement direction to the tank using the Rigidbody.
        rb.velocity = movementDirection;

        // Calculate the rotation amount based on the horizontal input.
        float rotationAmount = horizontalMove * rotatesens * Time.fixedDeltaTime;

        // Rotate the tank in the horizontal direction.
        transform.Rotate(0, rotationAmount, 0);
    }
}
