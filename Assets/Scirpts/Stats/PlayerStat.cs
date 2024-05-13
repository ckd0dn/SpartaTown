using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStat : MonoBehaviour
{
    private string name;
    public TextMeshProUGUI nameText;

    private void Awake()
    {
        name = GameManager.Instance.playerName;
        nameText.text = name;
    }

}
