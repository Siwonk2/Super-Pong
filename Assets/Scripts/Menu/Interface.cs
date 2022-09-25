using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Interface : MonoBehaviour
{
      public void hoverSound(){
     FindObjectOfType<AudioManager>().play("Menu_Option_Hover");
    }

    public void selectSound(){
     FindObjectOfType<AudioManager>().play("Menu_Option_Select");
    }
}
