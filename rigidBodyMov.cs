using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class rigidBodyMov : MonoBehaviour
{
    private Vector3 playerMovementInput;
    private Vector2 MouseInput;

    [SerializeField] private Transform PlayerCamera;
    [SerializeField] private Rigidbody PlayerBody;

    [SerializeField] private float Speed;
    [SerializeField] private float Sensitivity;
    //[SerializeField] private float JumpForce;

    private void Update()
    {
        playerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        MovePlayer();
        MovePlayerCam();
    }

    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(playerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3(MoveVector.x,PlayerBody.velocity.y,MoveVector.z);


        

    }

    private void MovePlayerCam()
    {

    }
}
