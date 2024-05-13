using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStat : MonoBehaviour
{
    private string name;
    public Text nameText;
    public SpriteRenderer spriteRenderer;

    private void Awake()
    {
        name = GameManager.Instance.playerName;
        nameText.text = name;
        spriteRenderer.sprite = GameManager.Instance.playerMainImage.sprite;
    }

}
