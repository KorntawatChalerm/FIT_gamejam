using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb2d;
    [SerializeField]
    private float speed = 10f;
    [SerializeField]
    private float jumpforce = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal,0);
        rb2d.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb2d.AddForce(new Vector2(0, jumpforce));

        }
    }
}
