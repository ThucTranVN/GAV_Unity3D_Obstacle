using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIManager : BaseUIManager
{
    public GameObject mainMenu;
    public GameObject settingMenu;

    public void OnClickSettingButton()
    {
        mainMenu.SetActive(false);
        settingMenu.SetActive(true);
    }

    public void OnClickSettingBackButton()
    {
        mainMenu.SetActive(true);
        settingMenu.SetActive(false);
    }

    public void OnClickTwitterButton(string url = "https://twitter.com")
    {
        Application.OpenURL(url);
    }

    public void OnClickDiscordButton(string url = "https://discord.com")
    {
        Application.OpenURL(url);
    }

    public void OnClickInstagramButton(string url = "https://www.instagram.com")
    {
        Application.OpenURL(url);
    }

}
