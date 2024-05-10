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
        name = PlayerPrefs.GetString("PlayerName");
        nameText.text = name;
    }

    private void Update()
    {
        Debug.Log(name);
    }
}
