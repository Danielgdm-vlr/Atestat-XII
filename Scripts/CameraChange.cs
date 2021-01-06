using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCamera;
    public GameObject FarCamera;
    public GameObject FirstPersonCamera;
    public int CameraMode;

    void Update()
    {
        if (Input.GetButtonDown("ViewMode"))
        {
            if (CameraMode == 2)
                CameraMode = 0;
            else
                CameraMode += 1;
            StartCoroutine(ModeChange ());
        }
    }
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CameraMode == 0)
        {
            NormalCamera.SetActive(true);
            FirstPersonCamera.SetActive(false);
        }
        if(CameraMode == 1)
        {
            FarCamera.SetActive(true);
            NormalCamera.SetActive(false);

        }
        if(CameraMode == 2)
        {
            FirstPersonCamera.SetActive(true);
            FarCamera.SetActive(false);

        }
       
    }
}
