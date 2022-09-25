using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelectMenu : Interface
{
   private static int PlayerNumber;

   public void singlePlayer(){
    selectSound();
    PlayerNumber = 1;
    SceneManager.LoadScene("Pong");
   }

   public void multiPlayer(){
      selectSound();
    PlayerNumber = 2;
    SceneManager.LoadScene("Pong");
   }

   public static int getPlayerNumber(){
    return PlayerNumber;
   }

   public void Back(){
      selectSound();
    SceneManager.LoadScene("Start_Menu");
   }
}

