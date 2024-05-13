using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    private float playTime;

    public TextMeshProUGUI playTimeText;

    void Update()
    {
        OnPalyTime();
    }

    private void OnPalyTime()
    {
        playTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(playTime / 60);
        int seconds = Mathf.FloorToInt(playTime % 60);
        playTimeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
