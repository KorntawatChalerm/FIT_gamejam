using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UntouchableObject : MonoBehaviour
{

    public GameObject player;
    public GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        //touch and boom die
        // collision.gameObject.SetActive(false);
        Vector3 tmp = gameManager.spawnPos.position ;
        collision.gameObject.transform.position = tmp;
    }
}
