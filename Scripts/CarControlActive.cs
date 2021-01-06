using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject RaceAI_car;


    void Start()
    {
        CarControl.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        RaceAI_car.GetComponent<UnityStandardAssets.Vehicles.Car.CarAIControl>().enabled = true;
    }
}
