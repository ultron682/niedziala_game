using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float Speed = 12;

    CharacterController characterController;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");



        Vector3 move = transform.forward * z + transform.right * x;
        characterController.SimpleMove(move * Speed * Time.deltaTime);
    }
}
