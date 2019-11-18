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
    public int antsPoolNumber;
    private int nextAnt;
    GameObject[]antsPool;
    GameObject queen;
    List<GameObject> workerAnts;
    List<GameObject> SoldierAnts;
    List<GameObject> collectorAnts;
    // Start is called before the first frame update
    void Start()
    {
        nextAnt = -1;
        antsPool = new GameObject[antsPoolNumber];
        for(int i = 0; i< antsPool.Length; i++)
        {
            antsPool[i] = Instantiate<GameObject>(WorldController.Instance_.antmolde);
            antsPool[i].SetActive(false);
        }
    }

    GameObject BornAnt(AntKind typeOf, Transform parent, Vector3 pos)
    {
        GameObject ant = antsPool[++nextAnt];
        ant.SetActive(true);
        if(parent !=null)
        {
            ant.transform.parent = parent;
        }
        if(pos != null)
        {
            ant.transform.position = pos;
        }
        /*
        switch(typeOf)
        {
            case:
                break;
            case:
                break;
            case:
                break;
            case:
                break;
            default: break;
        }
        */
        return ant;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
