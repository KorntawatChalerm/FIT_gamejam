using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    private float speed = 10f;
    
    [SerializeField]
    private float jumpforce = 10f;

    [SerializeField]
    private float forceDrop = 0f;

    bool onladder = false;
    bool facingRight = false;

    Animator anim ;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //moving horizontal
        if (Input.GetKey("a"))
        rb.velocity = new Vector2(-1 * speed, rb.velocity.y);
        
        if (Input.GetKey("d"))
        rb.velocity = new Vector2(1 * speed, rb.velocity.y);
        //jump
        if (Input.GetKeyDown("w") &&  Mathf.Abs(rb.velocity.y) <= 1 && onladder==false)
        {

            rb.AddForce(new Vector2(0, jumpforce*1000));
            

        }
        if(rb.velocity.y >= 5)
        {
            Physics.gravity = new Vector3(0, forceDrop, 0);
        }
       if (Input.GetKey("w") && onladder)
        {
            Debug.Log("climbing");
            rb.velocity = new Vector2(0,5);

        }
         //animation
         if(rb.velocity.x > 0){
            anim.SetBool("isWalk", true);
         }else{
            anim.SetBool("isWalk", false);

         }
        if ((rb.velocity.x > 0) && !facingRight){
            flip();
        }else if((rb.velocity.x < 0) && facingRight){
            flip();
        }

       // Debug.Log(rb.velocity);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ladder"))
        {
            Debug.Log("ladder");
            onladder = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ladder"))
        {
            Debug.Log("ladderoff");
            onladder = false;

        }


    }
    void flip(){
        facingRight = !facingRight;
        transform.Rotate(0f,180f,0f);
    }
}
