using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterButton : MonoBehaviour
{
    public GameObject characterBoard;
    public Image characterImg;
    public Image afterCharacterImg;
    public CharacterType characterType; 

    public void ViewCharacterBoard()
    {
        characterBoard.SetActive(true);
    }

    public void ChoiceCharacter()
    {
        characterBoard.SetActive(false);
        characterImg.sprite = afterCharacterImg.sprite;
        GameManager.Instance.characterType = characterType;
    }
}
