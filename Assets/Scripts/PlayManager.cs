using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;
    [SerializeField] CustomEvent GameOverEvent;
    [SerializeField] CustomEvent PlayerWinEvent;

    int coin = 100; //TODO
    private void OnEnable()
    {
        GameOverEvent.OnInvoked.AddListener(GameOver);
        PlayerWinEvent.OnInvoked.AddListener(PlayerWin);
    }
    private void OnDisable()
    {
        GameOverEvent.OnInvoked.RemoveListener(GameOver);
        PlayerWinEvent.OnInvoked.RemoveListener(PlayerWin);
    }
    public void GameOver()
    {
        finishedText.text = "You Failed";
        finishedCanvas.SetActive(true);
    }
    public void PlayerWin()
    {
        finishedText.text = "You Win! \nScore:" + GetScore();
        finishedCanvas.SetActive(true);
    }

    private int GetScore()
    {
        return coin * 10;
    }
}
