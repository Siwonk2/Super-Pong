using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Winner_Menu : Menu

{
public Text Player1_score;
public Text Player2_score;
public Text game_Winner;
public GameObject Winner_Menu_UI;


     public override void Resume(){
        Winner_Menu_UI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
     }
    

    public override void Pause(){
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void FixedUpdate(){
        if(Manager.getPlayer2Score() == 5|| Manager.getPlayer1Score() == 5){
            Manager.ball.gameObject.SetActive(false);
            Pause();
            makeGameWinnerMenu();
            Winner_Menu_UI.SetActive(true);
        }
    }

    private void makeGameWinnerMenu(){
        this.Player1_score.text = Manager.getPlayer1Score().ToString();
        this.Player2_score.text = Manager.getPlayer2Score().ToString();
        this.game_Winner.text = Manager.getGameWinner();
    }

    public override void Restart(){
        Manager.ResetGame();
        Resume();
    }



    
}
