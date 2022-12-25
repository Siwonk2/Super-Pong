using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : Menu
{


    public  GameObject pauseMenuUI;

    void Update(){

        if(Input.GetKeyDown(KeyCode.Escape)){

        
        if(GameIsPaused){
            Resume();
        }
        else
        {
            Pause();
        }
    }
   
}

public override void Resume()
    {  
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public override void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public override void Restart(){
        Manager.ResetGame();
        this.Resume();
        
    }
    

}
