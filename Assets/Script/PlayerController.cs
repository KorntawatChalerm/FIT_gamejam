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
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //moving horizontal
        /*float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * speed,rb.velocity.y);*/
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;


        //jump
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) <= 1)
        {

            rb.AddForce(new Vector2(0, jumpforce*1000));
        }
    }
}
