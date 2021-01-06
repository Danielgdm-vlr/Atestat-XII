using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;
    public GameObject MinutesDisplay;
    public GameObject SecondsDisplay;
    public GameObject MilisecondsDisplay;

    public GameObject LapCounter;
    public static int Laps;

    public float RawTime;

    public GameObject RaceFinish;

    void Update()
    {
        if (Laps == 2)
        {
            RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter()
    {
        Laps += 1;

        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManager.RawTime <= RawTime)
        {
            if (LapTimeManager.SecondsCount <= 9)
                SecondsDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondsCount + ".";
            else
                SecondsDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondsCount + ".";
            if (LapTimeManager.MinutesCount <= 9)
                MinutesDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinutesCount + ":";
            else
                MinutesDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinutesCount + ":";
            MilisecondsDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilisecondsCount;
        }

        PlayerPrefs.SetInt("MinutesSave", LapTimeManager.MinutesCount);
        PlayerPrefs.SetInt("SecondsSave", LapTimeManager.SecondsCount);
        PlayerPrefs.SetFloat("MilisecondsSave", LapTimeManager.MilisecondsCount);
        PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

        LapCounter.GetComponent<Text>().text = "" + Laps;

        LapTimeManager.MinutesCount = 0;
        LapTimeManager.SecondsCount = 0;
        LapTimeManager.MilisecondsCount = 0;
        LapTimeManager.RawTime = 0;

        HalfLapTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);

    }
}
