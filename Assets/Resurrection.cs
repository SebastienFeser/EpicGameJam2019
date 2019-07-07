using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resurrection : MonoBehaviour
{
    GeneralMovements activeScript;
    GameObject[] humanList;
    GameObject[] rabbitList;
    GameObject[] chickenList;
    GameObject[] foxList;

    void Awake()
    {
        seekPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        if (activeScript == null)
        {
            seekPlayer();
        }
    }

    void seekPlayer()
    {
        int random1 = Random.Range(0, 4);
        if (random1 == 0)
        {
            humanList = GameObject.FindGameObjectsWithTag("human");
            int random2 = Random.Range(0, humanList.Length);
            activeScript = humanList[random2].GetComponent<GeneralMovements>();
            activeScript.enabled = true;
        }else if(random1 == 1)
        {
            rabbitList = GameObject.FindGameObjectsWithTag("rabbit");
            int random2 = Random.Range(0, rabbitList.Length);
            activeScript = rabbitList[random2].GetComponent<GeneralMovements>();
            activeScript.enabled = true;
        }
        else if (random1 == 2)
        {
            chickenList = GameObject.FindGameObjectsWithTag("chicken");
            int random2 = Random.Range(0, chickenList.Length);
            activeScript = chickenList[random2].GetComponent<GeneralMovements>();
            activeScript.enabled = true;
        }
        else if (random1 == 3)
        {
            foxList = GameObject.FindGameObjectsWithTag("fox");
            int random2 = Random.Range(0, foxList.Length);
            activeScript = foxList[random2].GetComponent<GeneralMovements>();
            activeScript.enabled = true;
        }
    }
}
