using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject FinishCamera;
    public GameObject ViewMode;
    public GameObject LevelMusic;
    public GameObject CompleteTrigger;
    public GameObject LapPanel;
    public GameObject LapReqPanel;
    public GameObject MiniMap;
    public GameObject CarControls;
    public AudioSource FinishMusic;
    public GameObject CongratulationsText;

    private void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        MyCar.SetActive(false);
        CompleteTrigger.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        MyCar.SetActive(true);
        FinishCamera.SetActive(true);
        LevelMusic.SetActive(false);
        ViewMode.SetActive(false);
        LapPanel.SetActive(false);
        LapReqPanel.SetActive(false);
        MiniMap.SetActive(false);
        CarControls.SetActive(false);
        CongratulationsText.SetActive(true);
        FinishMusic.Play();
    }
 }
