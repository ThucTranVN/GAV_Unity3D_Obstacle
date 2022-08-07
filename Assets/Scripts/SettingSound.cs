using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingSound : MonoBehaviour
{
    public Slider volumeSlider;

    void Start()
    {
        LoadVolume();
    }

    public void SetVolume(float value)
    {
        AudioListener.volume = value;
        PlayerPrefs.SetFloat(CONSTANT.PP_VOLUME, value);
    }

    void LoadVolume()
    {
        volumeSlider.value = PlayerPrefs.GetFloat(CONSTANT.PP_VOLUME);
    }
}
