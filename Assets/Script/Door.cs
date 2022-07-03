using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
   // GameManager gameManager;
    void Start()
    {
       // gameManager = GetComponent<GameManager>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((GameManager.key.Count == GameManager.requiredkey) && other.CompareTag("player"))
        {
            Debug.Log(other.name);
            GameManager.instance.pass();
        }
    }
}
