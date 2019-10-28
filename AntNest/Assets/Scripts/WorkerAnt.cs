using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerAnt : Ant
{

    private enum FSMGlobal
    {
        OUTSIDE,
        INSIDE
    }
    private enum FSMInside
    {
        FOODFOUND,
        FEROMONEFOUND,
        SEARCHING,
        BACK
    }

    // Start is called before the first frame update
    override
    public void Start()
    {
        age = 0;
        hunger = 0;
        health = 100;
    }

    // Update is called once per frame
    override
    public void Update()
    {
        
    }
}
