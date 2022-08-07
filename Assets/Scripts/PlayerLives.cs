using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public Image[] playerLivesImg;
    private int liveRemaining;

    void Start()
    {
        liveRemaining = playerLivesImg.Length;
    }

    public void LooseLive()
    {
        if (liveRemaining == 0)
            return;
        liveRemaining--;
        playerLivesImg[liveRemaining].enabled = false;
    }
}
