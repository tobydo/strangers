using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

class trigger : MonoBehaviour
{
    public Flowchart flowchart;


    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
  
        flowchart.ExecuteBlock("streaming");
    }
}