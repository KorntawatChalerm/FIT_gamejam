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
    void Start()
    {
        
    }

    void Update()
    {
        //moving horizontal
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal,0);
        rb.AddForce(movement * speed);

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) <= 1)
        {

            rb.AddForce(new Vector2(0, jumpforce*1000));

        }
    }
}
