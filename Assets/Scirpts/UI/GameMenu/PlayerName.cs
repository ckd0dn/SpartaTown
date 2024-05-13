using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public InputField playerNameInput;
    public GameObject nameBoard;
    private string playerName;

    private void Update()
    {
        playerName = playerNameInput.text;
    }

    public void ChangeName()
    {
        if (playerName.Length > 1 && playerName.Length < 11)
        {
            GameManager.Instance.playerName = playerName;
            playerNameText.text = GameManager.Instance.playerName;
            nameBoard.SetActive(false);
        }

    }
}
