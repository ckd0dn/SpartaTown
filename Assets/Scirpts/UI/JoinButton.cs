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
            // 플레이어 이름에 시작화면에서 입력한 이름넣어주기
            PlayerPrefs.SetString("PlayerName", playerName);
        }

    }
}
