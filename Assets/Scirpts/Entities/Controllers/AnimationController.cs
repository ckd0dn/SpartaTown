using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected MainController mainController;
    protected Animator animator;

    protected virtual void Awake()
    {
        mainController = GetComponent<MainController>();
        animator = GetComponentInChildren<Animator>();    
    }

}
