using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Panda;
public class WorkerAnt : Ant
{
    FSMGlobal state;
    // Start is called before the first frame update
    override
    public void Start()
    {
        state = FSMGlobal.INSIDE;
        age = 0;
        hunger = 0;
        health = 100;
        Behaviour();
    }

    // Update is called once per frame
    override
    public void Update()
    {
        
    }
    [Task]
    public void Behaviour()
    {
        base.Behaviour();
        MoveRandom();
        Task.current.Succeed();
    }

    [Task]
    public void MoveRandom()
    {
        Debug.Log("fd");
        Task.current.Succeed();
    }
    [Task]
    override
    public void isAlive()
    {
        Debug.Log("isAlive hijo");
      
    }

}
