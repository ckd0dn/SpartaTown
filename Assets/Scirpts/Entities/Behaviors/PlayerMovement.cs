using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private MainController controller;
    private Rigidbody2D rigidbody2D;

    private Vector2 moveDirection = Vector2.zero;   

    private void Awake()
    {
        controller = GetComponent<MainController>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        moveDirection = direction; 
    }

    private void FixedUpdate()
    {
        ApplyMove();
    }

    private void ApplyMove()
    {
        // 속도 추가해야댐
        float speed = 7f;
        rigidbody2D.velocity = moveDirection * speed;
    }




}
