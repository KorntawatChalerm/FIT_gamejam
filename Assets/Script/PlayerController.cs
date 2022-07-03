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

    bool onladder = false;


    void Start()
    {
     //   rb = GetComponent<Rigidbody>();
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
