using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
// скрипт активирует какие-то предметы если с ними взаимодействует игрок 

public class key : MonoBehaviour
{   
    private Animator doorAnimator;

    // Start is called before the first frame update
    void Start()
    {
        doorAnimator = GameObject.Find("door").GetComponent<Animator>();   //название итема который надо активировать
    }


    private void OnTriggerEnter(Collider other) 
    {
        //print("Colider " + other.GameObject.name);
        if (other.gameObject.name.Equals("player"))    // кто активирует предмет 
    {
        doorAnimator.SetBool("StartDoorAnim", true);
    }
       
    }
}

//https://www.youtube.com/watch?v=-GYKJmL5rE0&list=PLmjT2NFTgg1dHzSzt3-OiRyouENbLLKdh&index=6