using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class InHouseEditor : MonoBehaviour
{
    [MenuItem("InHouseEditor/Open Scene/Menu &1")]
    public static void OpenSceneMenu()
    {
        OpenScene("Menu");
    }

    [MenuItem("InHouseEditor/Open Scene/Main &2")]
    public static void OpenSceneMain()
    {
        OpenScene("Main");
    }

    [MenuItem("InHouseEditor/Delete All PlayerPrefs &3")]
    public static void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("----------Deleted All----------");
    }


    public static void OpenScene(string sceneName)
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene("Assets/Scenes/" + sceneName + ".unity");
        }
    }
}