using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int MinutesCount;
    public static int SecondsCount;
    public static float MilisecondsCount;
    public static string MilisecondsDisplay;

    public GameObject MinutesBox;
    public GameObject SecondsBox;
    public GameObject MilisecondsBox;

    public static float RawTime;

    void Update()
    {
        RawTime += Time.deltaTime;
        MilisecondsCount += Time.deltaTime * 10;
        MilisecondsDisplay = MilisecondsCount.ToString("F0");
        MilisecondsBox.GetComponent<Text>().text = "" + MilisecondsDisplay;
        if (MilisecondsCount >= 10)
        {
            MilisecondsCount = 0;
            SecondsCount += 1;
        }
        if (SecondsCount <= 9)
            SecondsBox.GetComponent<Text>().text = "0" + SecondsCount + ".";
        else
            SecondsBox.GetComponent<Text>().text = "" + SecondsCount + ".";
        if (SecondsCount >= 60)
        {
            SecondsCount = 0;
            MinutesCount += 1;
        }
        if (MinutesCount <= 9)
            MinutesBox.GetComponent<Text>().text = "0" + MinutesCount + ":";
        else
            MinutesBox.GetComponent<Text>().text = "" + MinutesCount + ":";
    }
}