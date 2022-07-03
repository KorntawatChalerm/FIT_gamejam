using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private float jumpforce = 0.4f;

    bool onladder = false;


    void Start()
    {
     //   rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //moving horizontal
        if (Input.GetKey("a"))
        rb.velocity = new Vector2(-1 * speed, rb.velocity.y);
        
        if (Input.GetKey("d"))
        rb.velocity = new Vector2(1 * speed, rb.velocity.y);

        //jump
        if (Input.GetKeyDown("w") &&  Mathf.Abs(rb.velocity.y) <= 0.3 && onladder==false)
        {

            rb.AddForce(new Vector2(0, jumpforce*1000));

        }
       if (Input.GetKey("w") && onladder)
        {
            Debug.Log("climbing");
            rb.velocity = new Vector2(0,5);

           // rb.AddForce(new Vector2(0, 20));
        }
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
}
