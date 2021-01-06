using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacePositionUp : MonoBehaviour
{
    public GameObject PositionDisplay;
    public static int PositionUp;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CarPosition")
        {
            PositionDisplay.GetComponent<Text>().text = "1";
            PositionUp = 1;
        }
        PositionUp = 0;
    }
}
