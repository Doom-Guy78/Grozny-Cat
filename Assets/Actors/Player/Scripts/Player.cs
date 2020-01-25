using UnityEngine;

public class Player : MonoBehaviour
{

    // Stats

    public int health = 100;

    // Movement

    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;
    float walkSpeed = 40f;

    bool jump = false;
    bool crouch = false;

    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * walkSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            
            crouch = true;

        } else if (Input.GetButtonUp("Crouch")){
            
            crouch = false;
        }


    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool crch)
    {
        animator.SetBool("IsCrouching", crch);
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.deltaTime, crouch, jump);
        jump = false;
        
    }

    // Combat

    // Saving states

}
