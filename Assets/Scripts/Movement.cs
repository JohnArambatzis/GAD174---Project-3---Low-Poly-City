using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5.0f;

    public CharacterController controller;
    public Vector3 moveDirection;
    public float gravity = 20f;


    void Start()
    {
        controller = this.gameObject.GetComponent<CharacterController>();
    }


    void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        if (Input.GetKey(KeyCode.W))
        {
            vertical++;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontal--;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontal++;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vertical--;
        }


        if (controller.isGrounded)
        {
            moveDirection = transform.TransformDirection(new Vector3(horizontal, 0, vertical));
            moveDirection *= speed;
            if (Input.GetKey(KeyCode.Space))
            {
                moveDirection.y = jumpForce;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


    }
}
