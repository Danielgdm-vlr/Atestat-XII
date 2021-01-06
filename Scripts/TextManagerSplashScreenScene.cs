using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextManagerSplashScreenScene : MonoBehaviour
{
    public GameObject OpeningText;
    public GameObject GamesNameText;

    void Start()
    {
        StartCoroutine(SplashScreenText());    
    }

    IEnumerator SplashScreenText()
    {
        yield return new WaitForSeconds(1);
        OpeningText.SetActive(true);
        yield return new WaitForSeconds(2);
        OpeningText.SetActive(false);
        yield return new WaitForSeconds(2);
        GamesNameText.SetActive(true);
        yield return new WaitForSeconds(3);
        GamesNameText.SetActive(false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
