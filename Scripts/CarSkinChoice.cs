﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSkinChoice : MonoBehaviour
{
    public GameObject RedBody;
    public GameObject BlueBody;
    public int CarImport;

    void Start()
    {
        CarImport = CarSkin.CarType;
        if (CarImport == 1)
            RedBody.SetActive(true);
        if (CarImport == 2)
            BlueBody.SetActive(true);
    }


}
