using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
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
        if (Input.GetKey("left"))
        rb.velocity = new Vector2(-1 * speed, rb.velocity.y);
        
        if (Input.GetKey("right"))
        rb.velocity = new Vector2(1 * speed, rb.velocity.y);

        //jump
        if (Input.GetKeyDown("up") && Mathf.Abs(rb.velocity.y) <= 0.3 && onladder == false)
        {

            rb.AddForce(new Vector2(0, jumpforce * 1000));

        }
        if (Input.GetKey("up") && onladder)
        {
            Debug.Log("climbing");
            rb.velocity = new Vector2(0, 5);

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
