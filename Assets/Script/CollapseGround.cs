using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapseGround : MonoBehaviour
{
   public GameObject ground;
   public GameObject particle;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ground.SetActive(false);
        particle.SetActive(true);
    }

}
