using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Text Player1Score;
    public Text Player2Score;

    public Player_2Paddle Player2Paddle;

    public Player_1Paddle Player1Paddle;

    private int _player1_Score;
    private int _player2_Score;
    private string GameWinner;
    
    void Start(){
    
        FindObjectOfType<AudioManager>().stop("Menu_Theme");
        FindObjectOfType<AudioManager>().play("Game_Theme");
    }

    public void Player1Scores(){
        FindObjectOfType<AudioManager>().play("Point_Scored");
        _player1_Score++;
        this.Player1Score.text = _player1_Score.ToString();
        if(_player1_Score == 2){
            GameWinner = "PLAYER 1 WINS!";
            return;
        }
       ResetGameState();
    }

    public void Player2Scores(){
        FindObjectOfType<AudioManager>().play("Point_Scored");
        _player2_Score++;
        this.Player2Score.text = _player2_Score.ToString();
        if(_player2_Score == 2){
            if(getPlayerSelectNumber() == 1){
            GameWinner = "COMPUTER WINS!";
            }
            else{
            GameWinner = "Player 2 WINS!";
            }
            return;
        }
        ResetGameState();
    }

    private void ResetGameState(){
        this.Player1Paddle.ResetPosition();
        this.Player2Paddle.ResetPosition();
        this.ball.gameObject.SetActive(true);
         this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void ResetGame(){
        FindObjectOfType<AudioManager>().stop("Game_Theme");
        FindObjectOfType<AudioManager>().play("Game_Theme");
        ResetGameScore();
        ResetGameState();
    }

    public void ResetGameScore(){
        _player1_Score = 0;
        _player2_Score = 0;
        this.Player1Score.text = _player1_Score.ToString();
        this.Player2Score.text = _player2_Score.ToString();
    }


    public int getPlayer1Score(){
        return _player1_Score;
    }

     public int getPlayer2Score(){
        return _player2_Score;
    }

    public string getGameWinner(){
        return GameWinner;
    }

    public int getPlayerSelectNumber(){
        return PlayerSelectMenu.getPlayerNumber();
    }

   


    

}
