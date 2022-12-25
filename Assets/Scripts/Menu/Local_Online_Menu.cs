using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Local_Online_Menu : Interface
{
  
  void LocalMultiplayer(){
    selectSound();
    SceneManager.LoadScene("Pong");
  }

  void OnlineMultiplayer(){
    
  }


  public void Back(){
      selectSound();
    SceneManager.LoadScene("Player_Menu");
   }
   
}
