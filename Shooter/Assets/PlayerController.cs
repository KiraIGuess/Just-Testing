using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerFunctions))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 4f;

    private PlayerFunctions Functionality;

    private void Start()
    {
        Functionality = GetComponent<PlayerFunctions>();
    }

    private void Update()
    {
        // Gets input
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        // Vectors to get the direction 
        Vector3 _moveHorizontal = transform.right * _xMov;
        Vector3 _moveVertical = transform.forward * _zMov;

        Vector3 _Velocity = (_moveVertical + _moveHorizontal).normalized * speed;
        // Gets the Velocity of PlayerFunctions = _Velocity
        Functionality.Move(_Velocity);

        // Get the rotation  as a 3D vector ( turning left right not up down since Y rotation is that way)
        float _yRot = Input.GetAxisRaw("Mouse X");   
        Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;
    }

}
