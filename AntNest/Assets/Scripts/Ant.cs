using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Ant : MonoBehaviour
{

    public enum FSMGlobal
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

    public int nestId { get; set; }
    public int id { get; set; }
    public int age { get; set; }
    public float hunger { get; set; }
    public float health { get; set; }
    public GameObject target { get; set; }



    // Start is called before the first frame update
    public abstract void Start();

    // Update is called once per frame
    public abstract void Update();

}
