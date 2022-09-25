using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : Interface
{
  void Awake(){
   if(FindObjectOfType<AudioManager>().isPlaying("Menu_Theme")){
      return;
   }
   FindObjectOfType<AudioManager>().play("Menu_Theme");
  }

   public void PlayGame(){
        selectSound();
        SceneManager.LoadScene("Player_Menu");
    }

    public void QuitGame(){
      selectSound();
       Application.Quit(); 
    }

   
}
