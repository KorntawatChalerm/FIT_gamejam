using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentingPlatform : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("player"))
        {
            Debug.Log(collision.tag);
          collision.transform.parent = this.transform;
           }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            other.transform.parent = null ;

        }


    }
}
