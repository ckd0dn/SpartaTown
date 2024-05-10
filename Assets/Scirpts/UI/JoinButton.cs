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
        Debug.Log(playerNameInput.text);
    }

    public void JoinGame()
    {
        SceneManager.LoadScene("MainScene");
        // �÷��̾� �̸��� ����ȭ�鿡�� �Է��� �̸��־��ֱ�
        PlayerPrefs.SetString("PlayerName", playerName);
    }
}
