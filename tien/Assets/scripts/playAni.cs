using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
       ani.enabled = true;
      
        Debug.Log(animationName);
        ani.SetBool(animationName, true);
        ani.SetBool(lastAnimation, false);
        ani.SetBool("isWalking", false);
     ani.Play(animationName);
    }

     public void AnimateText(string animationName, string lastAnimation){
       ani.enabled = true;
        Text texty = GetComponent<Text>();
        texty.enabled = true;
      
        Debug.Log(animationName);
        ani.SetBool(animationName, true);
        ani.SetBool(lastAnimation, false);
        ani.SetBool("isWalking", false);
     ani.Play(animationName, -1, 0f);
    }

    public void StopIt(){
        ani.enabled = false;
       Text texty = GetComponent<Text>();

       texty.enabled = false;
    }
}
