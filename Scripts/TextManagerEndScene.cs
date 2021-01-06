using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManagerEndScene : MonoBehaviour
{
    public GameObject ThankYouText;
    public GameObject QuitGameText;
    public GameObject ButtonQuitGame;
    void Start()
    {
        StartCoroutine(TextOnScreen());
    }

    IEnumerator TextOnScreen()
    {
        yield return new WaitForSeconds(2);
        ThankYouText.SetActive(true);
        yield return new WaitForSeconds(4);
        QuitGameText.SetActive(true);
        yield return new WaitForSeconds(5);
        ButtonQuitGame.SetActive(true);
    }
}
