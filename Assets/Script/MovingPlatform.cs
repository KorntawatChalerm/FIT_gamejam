using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform pos1,pos2;
    public float speed;
    public Transform startpos;
    public GameObject player;

    Vector3 nextpos;
    void Start()
    {
        nextpos = startpos.position;
    }

    void Update()
    {   
        if(transform.position == pos1.position){
            nextpos = pos2.position;
        }
         if(transform.position == pos2.position){
            nextpos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position,nextpos,speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("player"))
        {
           player.transform.parent = collision.gameObject.transform;
           }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            player.transform.parent = null ;

        }


    }
}
