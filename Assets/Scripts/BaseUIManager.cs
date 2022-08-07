using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUIManager : Singleton<BaseUIManager>
{
    public ScenceLoader scenceLoader;

    public void OnUICLick()
    {
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySound("UIClick");
        }

    }

    public void OnUIHover()
    {
        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlaySound("UIHover");
        }
    }

    public virtual void ShowUILooseGame()
    {
        
    }

    public virtual void ShowUIWinGame()
    {
        
    }
}
