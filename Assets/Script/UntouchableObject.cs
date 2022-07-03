using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UntouchableObject : MonoBehaviour
{

   // public GameObject player;
   // public GameManager gameManager;
    void Start()
    {
       // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        if (gameObject.transform.position.y <= -100 )
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        //touch and boom die
        if (collision.CompareTag("player"))
        {
            Vector3 tmp = GameManager.instance.spawnPos.position;    //gameManager.spawnPos.position;
            collision.gameObject.transform.position = tmp;
        }
    }
}
