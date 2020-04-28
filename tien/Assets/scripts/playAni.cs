using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAni : MonoBehaviour
{
    private Animator ani;
    

    // Start is called before the first frame update
    void Start()
    { 
        ani = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Animate(string animationName, string lastAnimation){
       
      
        Debug.Log(animationName);
        ani.SetBool(animationName, true);
        ani.SetBool(lastAnimation, false);
     ani.Play(animationName);
    }
}
