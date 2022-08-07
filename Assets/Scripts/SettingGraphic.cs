using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingGraphic : MonoBehaviour
{
    public TMP_Dropdown qualityDD;
    private int indexDD;
    // Start is called before the first frame update
    void Start()
    {
        indexDD = PlayerPrefs.GetInt(CONSTANT.PP_QUALITY);
        qualityDD.value = indexDD;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt(CONSTANT.PP_QUALITY, qualityIndex);
    }  
}
