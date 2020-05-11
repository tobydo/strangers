using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopWalk : MonoBehaviour
{
    public GameObject tien;
    // Start is called before the first frame update


    void StopWalk()
    {
        player Player = tien.GetComponent<player>();

        Player.enabled = false;

    }
}
