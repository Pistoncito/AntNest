using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ant : MonoBehaviour
{

    protected int age;
    protected float hunger;
    protected float health;

    // Start is called before the first frame update
    public abstract void Start();

    // Update is called once per frame
    public abstract void Update();
}
