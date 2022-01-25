using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // adjusts the speed
    public float speed = 0;
    // references 'rigid body' component of the game object
    private Rigidbody rb;

    // Individual input directions
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Onmove is called for the player to control the ball
    void OnMove(InputValue movementValue)
    {
        // Function body
        Vector2 movementVector = movementValue.Get<Vector2>();

        // to keep the consistency of the private floats
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // The fuction that applies the force to move the ball
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }
}
