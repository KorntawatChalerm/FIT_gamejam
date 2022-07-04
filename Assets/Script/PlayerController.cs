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
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed,rb.velocity.y);
       /* var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        transform.position +=  new Vector3(horizontal, 0) * Time.deltaTime * speed;*/

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
