using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverGreen : MonoBehaviour
{

    public GameObject target;
    public Transform targetposition;
    public float speed = 1;
    bool triggered;
    Vector3 targetpos;

    void Start()
    {
        targetpos = targetposition.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(triggered){
        target.transform.position = Vector3.MoveTowards(target.transform.position,targetpos,speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("lever");
        triggered = true;
    }
}
