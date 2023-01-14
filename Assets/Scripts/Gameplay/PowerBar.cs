using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{

    public Image[] PowerPoint;

    public GameManager manager;

    void Start () {
        for(int i = 0; i < PowerPoint.Length; i++)
        PowerPoint[i].gameObject.SetActive(false);
    }

    public void UpdatePowerBar(int powerLevel){
       
            PowerPoint[powerLevel].gameObject.SetActive(true);
        
    }

    public void emptyPowerBar(){

        for(int i = 0; i < PowerPoint.Length; i++)
            PowerPoint[i].gameObject.SetActive(false);  
    }
}


        
    

