﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorunlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake(){
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
