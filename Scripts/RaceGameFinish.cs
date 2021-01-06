using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceGameFinish : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(RaceGameFinish01());
    }
    IEnumerator RaceGameFinish01()
    {
        if (LapComplete.Laps == 2)
        {
            yield return new WaitForSeconds(20);
            SceneManager.LoadScene(6);
        }
    }
}
