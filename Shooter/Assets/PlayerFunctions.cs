using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Creates a rigidbody is there isn't
[RequireComponent(typeof(Rigidbody))]
public class PlayerFunctions : MonoBehaviour
{
    private Vector3 Velocity = Vector3.zero;
    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }


    private void FixedUpdate()
    {
        performMovement();
    }


    // Gets the velocity from PlayerController inputs
    public void Move(Vector3 _Velocity)
    {
        Velocity = _Velocity;
    }

    // Moves the rigidbody using MovePosition 
    private void performMovement()
    {
        if (Velocity != Vector3.zero)
        {
            rb.MovePosition(rb.position + Velocity*Time.fixedDeltaTime);
        }
    }

}
