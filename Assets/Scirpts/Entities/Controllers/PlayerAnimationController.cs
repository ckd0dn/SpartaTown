using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimationController : AnimationController
{
    private static readonly int isWalkiing = Animator.StringToHash("isWalking");

    private readonly float minMoveSpeed = 0.3f;
  

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        mainController.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        nowAnim.SetBool(isWalkiing, vector.magnitude > minMoveSpeed);

    }

}
