using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;

    Vector3 velo;
  
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velo.y += gravity * Time.deltaTime;

        controller.Move(velo * Time.deltaTime);
    }
}
