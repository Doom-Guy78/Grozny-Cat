using UnityEngine;

public class Player : MonoBehaviour
{

    // Stats

    public int health = 100;

    // Movement

    public CharacterController2D controller;

    float horizontalMove = 0f;
    float walkSpeed = 40f;

    bool jump = false;
    bool crouch = false;

    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            
            crouch = true;

        } else if (Input.GetButtonUp("Crouch")){
            
            crouch = false;
        }


    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * walkSpeed * Time.deltaTime, crouch, jump);
        jump = false;
    }

    // Combat

    // Saving states

}
