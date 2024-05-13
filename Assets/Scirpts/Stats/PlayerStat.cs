using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    private string name;
    public Text nameText;

    private void Awake()
    {
        name = GameManager.Instance.playerName;
        nameText.text = name;
        Debug.Log(GameManager.Instance.characterType);
    }

}
