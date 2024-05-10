using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinButton : MonoBehaviour
{
    private string playerName;
    public InputField playerNameInput;

    private void Update()
    {
        playerName = playerNameInput.text;
    }

    public void JoinGame()
    {
        if(playerName.Length > 1 && playerName.Length < 11)
        {
            SceneManager.LoadScene("MainScene");
            // �÷��̾� �̸��� ����ȭ�鿡�� �Է��� �̸��־��ֱ�
            PlayerPrefs.SetString("PlayerName", playerName);
        }

    }
}
