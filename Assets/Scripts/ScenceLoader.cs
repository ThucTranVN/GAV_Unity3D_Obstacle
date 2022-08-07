using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceLoader : MonoBehaviour
{
    public Animator transitionAnim;
    public float transitionTime;

    public void LoadLevel(string sceneName)
    {
        StartCoroutine(LevelLoader(sceneName));
    }

    IEnumerator LevelLoader(string sceneName)
    {
        transitionAnim.SetTrigger("LoadScence");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
    }
}
