using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olharLados : MonoBehaviour
{
    Rigidbody rb;



   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }


    void Update()
    {
        
    }
}
