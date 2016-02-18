using UnityEngine;
using System.Collections;

public class HovershipController : MonoBehaviour {
    //Variables
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero; 

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        // is the controller on the ground?
        if (controller.isGrounded)
        {
            //Feed moveDirection with input.
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));//Input.GetAxis("Horizontal")
            moveDirection = transform.TransformDirection(-moveDirection);
            //Multiply it by speed.
            moveDirection *= speed;
            //Jumping
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        //Applying gravity to the controller
        moveDirection.y -= gravity * Time.deltaTime;
        //Making the character move
        controller.Move(moveDirection * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,-4,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 4, 0);
        }
    }
}
