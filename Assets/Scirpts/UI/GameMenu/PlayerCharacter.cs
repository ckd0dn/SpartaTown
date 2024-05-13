using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public GameObject characterBoard;
    public CharacterType characterType;
    public RuntimeAnimatorController penguinAnim;
    public RuntimeAnimatorController knightAnim;
    public Animator animator;

    public void ViewCharacterBoard()
    {
        bool isActive = characterBoard.active;
        characterBoard.SetActive(!isActive);
    }

    public void ChangeCharacterAnim()
    {
        GameManager.Instance.characterType = characterType;

        if(GameManager.Instance.characterType == CharacterType.Penguin )
        {
            animator.runtimeAnimatorController = penguinAnim;
        }else if(GameManager.Instance.characterType == CharacterType.Knight)
        {
            animator.runtimeAnimatorController = knightAnim;
        }

        characterBoard.SetActive(false);

    }
}
