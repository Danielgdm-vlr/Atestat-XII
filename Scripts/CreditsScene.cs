using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CreditsEnd());
    }
    IEnumerator CreditsEnd()
    {
        yield return new WaitForSeconds(20);
        SceneManager.LoadScene(7);
    }
}
