﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WorldController : MonoBehaviour
{
    //Editor variables
    public Ant antmolde;

    //Camera
    public CameraMovement cam;

    //Game state
    bool outside;

    //Game Object lists 
    List<Ant> ants;
    List<Nest> nests;
    //Game parameters
    float temperature;

    // Start is called before the first frame update
    void Start()
    {
        ants = new List<Ant>();
        nests = new List<Nest>();
        outside = true;
        cam.goToSurface();
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switchCameraPos();
        }
    }

    void switchCameraPos()
    {
        outside = !outside;
        if (outside)
        {
            cam.goToSurface();
        }
        else
        {
            cam.gotToAnthill();
        }
    }
}
