using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int MinutesCount;
    public int SecondsCount;
    public float MilisecondsCount;

    public GameObject MinutesDisplay;
    public GameObject SecondsDisplay;
    public GameObject MilisecondsDisplay;

    void Start()
    {
        MinutesCount = PlayerPrefs.GetInt("MinutesSave");
        SecondsCount = PlayerPrefs.GetInt("SecondsSave");
        MilisecondsCount = PlayerPrefs.GetFloat("MilisecondsSave");

        MinutesDisplay.GetComponent<Text>().text = "" + MinutesCount + ":";
        SecondsDisplay.GetComponent<Text>().text = "" + SecondsCount + ".";
        MilisecondsDisplay.GetComponent<Text>().text = "" + MilisecondsCount;
    }
}
