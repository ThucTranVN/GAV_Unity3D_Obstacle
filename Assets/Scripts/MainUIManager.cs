using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIManager : BaseUIManager
{
    public GameObject pauseBtn;
    public GameObject pausePanel;
    public GameObject loosePanel;
    public GameObject winPanel;
    public GameObject playerLives;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if (!pausePanel.activeSelf)
            {
                OnClickPauseButton();
            }
        }
    }

    public void OnClickPauseButton()
    {
        pauseBtn.SetActive(false);
        pausePanel.SetActive(true);
        GameManager.Instance.PauseGame();
    }

    public void OnClickPauseBackButton()
    {
        pauseBtn.SetActive(true);
        pausePanel.SetActive(false);
        GameManager.Instance.ResumeGame();
    }

    public override void ShowUILooseGame()
    {
        base.ShowUILooseGame();
        playerLives.SetActive(false);
        pauseBtn.SetActive(false);
        loosePanel.SetActive(true);
    }

    public override void ShowUIWinGame()
    {
        base.ShowUIWinGame();
        playerLives.SetActive(false);
        pauseBtn.SetActive(false);
        winPanel.SetActive(true);
    }

    public void OnClickRestartGameButton()
    {
        GameManager.Instance.ResetState();
        scenceLoader.LoadLevel("Main");
    }

    public void OnClickBackToMenuButton()
    {
        GameManager.Instance.ResetState();
        scenceLoader.LoadLevel("Menu");
    }
}
