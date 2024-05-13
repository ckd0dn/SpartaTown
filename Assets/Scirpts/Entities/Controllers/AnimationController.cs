using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected MainController mainController;
    protected Animator nowAnim;
    public RuntimeAnimatorController penguinAnim;
    public RuntimeAnimatorController knightAnim;

    protected virtual void Awake()
    {
        mainController = GetComponent<MainController>();
        nowAnim = GetComponentInChildren<Animator>();
        ChangeAnim();
    }

    private void ChangeAnim()
    {
        CharacterType characterType = GameManager.Instance.characterType;

        if(characterType == CharacterType.Penguin)
        {
            nowAnim.runtimeAnimatorController = penguinAnim;
        }
        else
        {
            nowAnim.runtimeAnimatorController = knightAnim;
        }
        
    }

}
