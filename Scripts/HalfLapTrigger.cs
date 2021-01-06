using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject LapHalfTrigger;

    private void OnTriggerEnter()
    {
        LapCompleteTrigger.SetActive(true);
        LapHalfTrigger.SetActive(false);
    }
}
