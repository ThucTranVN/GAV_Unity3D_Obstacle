using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameManager : Singleton<GameManager>
{
    public ScenceLoader sceneLoader;
    public int playerLives = 3;
    void Start()
    {
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySound("Background");
        }
        SetStartVolume();
        SetStartQuality();
    }

    private void SetStartVolume()
    {
        if (!PlayerPrefs.HasKey(CONSTANT.PP_VOLUME))
        {
            PlayerPrefs.SetFloat(CONSTANT.PP_VOLUME, CONSTANT.DEFAULT_VOLUME);
            AudioListener.volume = CONSTANT.DEFAULT_VOLUME;
        }
        else
        {
            float volume = PlayerPrefs.GetFloat(CONSTANT.PP_VOLUME);
            AudioListener.volume = volume;
        }
    }

    private void SetStartQuality()
    {
        if (!PlayerPrefs.HasKey(CONSTANT.PP_QUALITY))
        {
            PlayerPrefs.SetInt(CONSTANT.PP_QUALITY, CONSTANT.DEFAULT_QUALITY);
            QualitySettings.SetQualityLevel(CONSTANT.DEFAULT_QUALITY);
        }
        else
        {
            int qualityIndex = PlayerPrefs.GetInt(CONSTANT.PP_QUALITY);
            QualitySettings.SetQualityLevel(qualityIndex);
        }
    }

    public void ResetState()
    {
        Time.timeScale = 1f;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    public void EndGame()
    {
        Time.timeScale = 0f;

        if (MainUIManager.HasInstance)
        {
            MainUIManager.Instance.ShowUILooseGame();
        }

        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySound("Loose");
        }
    }

    public void WinGame()
    {
        Time.timeScale = 0f;
        if (MainUIManager.HasInstance)
        {
            MainUIManager.Instance.ShowUIWinGame();
        }
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySound("Win");
        }
    }

    public void OnClickStartGameButton()
    {
        sceneLoader.LoadLevel("Main");
    }

    public void OnClickExitGameButton()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
