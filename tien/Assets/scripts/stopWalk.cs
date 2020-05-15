using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopWalk : MonoBehaviour
{
    public GameObject tien;
    public GameObject body;
    // Start is called before the first frame update


    public void StopWalk()
    {
        CharacterController Play = tien.GetComponent<CharacterController>();
       player walking = body.GetComponent<player>();

        Play.enabled = false;
        walking.enabled = false;
        

    }

    public void StartWalk(){

          CharacterController Play = tien.GetComponent<CharacterController>();
       player walking = body.GetComponent<player>();

        Play.enabled = true;
        walking.enabled = true;
    }
}
