using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     Destroy (GameObject.Find("crowd"));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
