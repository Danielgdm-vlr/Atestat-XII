using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacePositionDown : MonoBehaviour
{
    public GameObject PositionDisplay;
    public static int PositionDown;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPosition")
        {
            PositionDisplay.GetComponent<Text>().text = "2";
            PositionDown = 2;
        }
        else
            PositionDown = 0;
    }
}
