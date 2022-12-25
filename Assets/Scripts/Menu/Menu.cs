using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Menu:Interface
{

   public static bool GameIsPaused = false;
   public  GameManager Manager;

   public abstract void Restart();
        

    public void Quit(){
         Resume();
         FindObjectOfType<AudioManager>().stop("Game_Theme");
         SceneManager.LoadScene("Start_Menu");
         
    }

     public  abstract void Resume();
    

    public abstract void Pause();
    
  
}
