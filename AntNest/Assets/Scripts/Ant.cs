using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Panda;

public abstract class Ant : MonoBehaviour
{

    public enum FSMGlobal
    {
        OUTSIDE,
        INSIDE
    }
    public enum Feromone
    {
        FOOD,
        THREAT
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

    [Task]
    public virtual void Behaviour()
    {
        
        if(hunger <= 0.0f)
        {
            health -= Time.deltaTime;
        }
 
        if(health <= 0.0f)
        {
            Destroy(this);
            Task.current.Fail();
        }
   
        Debug.Log("Behaviour padre");
        Task.current.Succeed();

    }

    [Task]
    public virtual void isAlive()
    {
        Debug.Log("isAlive padre");
        
        if(health <= 0.0f)
        {
            Task.current.Fail();
        }
        
        Task.current.Succeed();
    }
}
