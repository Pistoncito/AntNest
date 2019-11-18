using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Feromone
{
    FOOD,
    THREAT
}
public class Nest : MonoBehaviour
{
    [HideInInspector]
    public int id;

    List<Ant> ants;
    // Start is called before the first frame update
    void Start()
    {
        ants = new List<Ant>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
