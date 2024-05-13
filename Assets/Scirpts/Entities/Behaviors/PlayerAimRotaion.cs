using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimRotaion : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerRenderer;

    private MainController controller;


    private void Awake()
    {
        controller = GetComponent<MainController>();
    }

    private void Start()
    {
        controller.OnLookEvent += RotateCharacter;
    }

    private void RotateCharacter(Vector2 vector)
    {
        float rotZ = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;

        playerRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
