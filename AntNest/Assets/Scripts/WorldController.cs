using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AntKind
{
    QUEEN,
    DRONE,
    SOLDIER,
    COLLECTOR,
    NURSE
}

public class WorldController : MonoBehaviour
{
    private static WorldController instance_;
    public static WorldController Instance_
    {
        get
        {
            return instance_;
        }
        set
        {
            if(instance_ != null)
            {
                instance_ = value;
            }
        }
    }
    //Editor variables
    public GameObject antmolde;

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
        instance_ = this;
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
