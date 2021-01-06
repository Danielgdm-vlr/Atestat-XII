using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject Countdown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public AudioSource LevelMusic;
    public GameObject LapTimer;
    public GameObject CarControls;
    public GameObject LapPanel;
    public GameObject LapReqPanel;
    public GameObject MiniMap;
    public GameObject GO;

    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);

        Countdown.GetComponent<Text>().text = "2";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);

        Countdown.GetComponent<Text>().text = "1";
        GetReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);

        GoAudio.Play();
        LevelMusic.Play();
        LapTimer.SetActive(true);
        CarControls.SetActive(true);

        LapPanel.SetActive(true);
        LapReqPanel.SetActive(true);
        MiniMap.SetActive(true);

        GO.SetActive(true);
        yield return new WaitForSeconds(1);
        GO.SetActive(false);
    }
}
