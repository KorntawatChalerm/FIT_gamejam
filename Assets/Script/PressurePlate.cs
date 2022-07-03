using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{    public GameObject target;
    public Transform targetposition;
    public Transform beginposition;
    public float speed = 1;
    bool triggered;
    Vector3 targetpos;
    Vector3 beginpos;

    void Start()
    {
        targetpos = targetposition.position;
        beginpos = beginposition.position;
    }

    void Update()
    {
        if(triggered){
        target.transform.position = Vector3.MoveTowards(target.transform.position,targetpos,speed * Time.deltaTime);
        }else
        {
        target.transform.position = Vector3.MoveTowards(target.transform.position,beginpos,speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("pressureOn");
        triggered = true;
    }
    private void OnTriggerExit(Collider other) {
        Debug.Log("pressureOff");
        triggered = false;
    }
}
