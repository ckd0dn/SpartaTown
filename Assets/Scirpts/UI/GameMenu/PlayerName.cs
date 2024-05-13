using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerName : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    public void ChangeName()
    {
        GameManager.Instance.playerName = "asdasd";

        nameText.text = GameManager.Instance.playerName;

    }
}
