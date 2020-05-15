using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stay : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        if (scene.name == "Restaurant")
        {
            // Destroy the gameobject this script is attached to
           
            Destroy(this);
            Debug.Log("destroyed");
        }
    }
}
