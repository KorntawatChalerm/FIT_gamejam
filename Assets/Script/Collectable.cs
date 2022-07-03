using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
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
            GameManager.key.Add(1);

            //disappear when touched
            Destroy(this.gameObject);
        }
    }
}
