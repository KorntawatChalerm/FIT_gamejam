using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UntouchableObject : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        //touch and boom die
        collision.gameObject.SetActive(false);
        GameManager.instance.dead();
        
    }
}
