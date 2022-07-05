using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private Animator playerAnimator;

    private bool playerIsFacingRight = true;
    private bool playerIsJumping = false;
    [SerializeField]
    private bool playerIsGrounded = false;
    
    public float moveInput;
    public float playerSpeed;    
    public float playerJumpForce;


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        
    }

    private void Update() 
    {                 
        moveInput = Input.GetAxis("Horizontal");    
        // 1
        if (playerIsGrounded)
        {       
           playerAnimator.SetBool("isJump",false);            
          //cattoAnimator.SetFloat("Velocity", Mathf.Abs(moveInput));
        }else
        {
            playerAnimator.SetBool("isJump",true);   
        }
        //2
        if (Input.GetKeyDown("space") && playerIsGrounded && !playerIsJumping )
        {
            Debug.Log("Space is pass");
            playerIsJumping = true;            
            //cattoAnimator.SetTrigger("Jump");
        }
  
    }

    private void FixedUpdate() 
    {
        playerRigidbody.velocity = new Vector3(moveInput * playerSpeed, playerRigidbody.velocity.y);
        if (playerIsFacingRight == true && moveInput > 0.00)
        {
            FlipCatto();
            playerAnimator.SetBool("isWalk",true);
        }
        else if (playerIsFacingRight == false && moveInput < 0.00)
        {
            FlipCatto();
            playerAnimator.SetBool("isWalk",true);
        }
       
        if (playerIsJumping)
        {
            playerRigidbody.AddForce(new Vector3(0f, playerJumpForce,0f));          
            playerIsJumping = false;  
            playerAnimator.SetBool("isJump",true);           
        }

        if(moveInput == 0)
        {
            playerAnimator.SetBool("isWalk",false);
        }

    }   

    private void FlipCatto()
    {
        playerIsFacingRight = !playerIsFacingRight;

        Vector3 PlayerScale = transform.localScale;
        PlayerScale.x *= -1;

        transform.localScale = PlayerScale;
    }

    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);
    }

    private void OnCollisionStay(Collision collision) 
    {
        if (collision.collider.tag == "ground")
        {
            playerIsGrounded = true;
            Debug.Log(playerIsGrounded);
        }
    }    

    private void OnCollisionExit(Collision collision) 
    {
            playerIsGrounded = false;   
    }

}
