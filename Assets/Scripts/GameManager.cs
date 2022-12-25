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

    public PowerBar Power_bar_P1;

    public PowerBar Power_bar_P2;

    public BouncySurface Player1Paddle_Bouncey;

     public BouncySurface Player2Paddle_Bouncey;


    private int _player1_Score;
    private int _player2_Score;
    private string GameWinner;

    private int _player1_power;

    private int _player2_power;

    private bool _player1_power_ready;

    private bool _player2_power_ready;
    
    void Start(){
        
        FindObjectOfType<AudioManager>().stop("Menu_Theme");
        FindObjectOfType<AudioManager>().play("Game_Theme");
        GameObject.Find("Player_1Paddle").SetActive(true);
        GameObject.Find("Player_2Paddle").SetActive(true);
        if(getPlayerSelectNumber()==1){
        Player2Paddle.setMovement(new Player_2MovementSingle());
        }
        else if(getPlayerSelectNumber()==2){
        Player2Paddle.setMovement(new Player_2MovementMultiplayer());
        }
        _player1_power = -1;
        _player2_power = -1;
        _player1_power_ready = false;
        _player2_power_ready = false;
    }

    public void Player1Scores(){
        FindObjectOfType<AudioManager>().play("Point_Scored");
        _player1_Score++;
        this.Player1Score.text = _player1_Score.ToString();
        if(_player1_Score == 5){
            GameWinner = "PLAYER 1 WINS!";
            return;
        }
       ResetGameState(false);
    }

    public void Player2Scores(){
        FindObjectOfType<AudioManager>().play("Point_Scored");
        _player2_Score++;
        this.Player2Score.text = _player2_Score.ToString();
        if(_player2_Score == 5){
            if(getPlayerSelectNumber() == 1){
            GameWinner = "COMPUTER WINS!";
            }
            else{
            GameWinner = "Player 2 WINS!";
            }
            return;
        }
        ResetGameState(false);
    }

    private void ResetGameState(bool resetgame){
        this.Player1Paddle.ResetPosition();
        this.Player2Paddle.ResetPosition();
        this.ball.gameObject.SetActive(true);
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.ball.resetBallSettings();
        if(resetgame){
        ClearPlayer1PowerBar();
        ClearPlayer2PowerBar();
        }
        this.Player1Paddle_Bouncey.resetBounceSettings();
        this.Player2Paddle_Bouncey.resetBounceSettings();

    }

    public void ResetGame(){
        FindObjectOfType<AudioManager>().stop("Game_Theme");
        FindObjectOfType<AudioManager>().play("Game_Theme");
        ResetGameScore();
        ResetGameState(true);
    }

    public void ResetGameScore(){
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

    public int get_Player_1_power_bar(){
        return _player1_power;
    }

    public int get_Player_2_power_bar(){
        return _player2_power;
    }

     public bool get_Player_1_power_ready(){
        return _player1_power_ready;
    }

    public bool get_Player_2_power_ready(){
        return _player2_power_ready;
    }

    public void Player_1Power_up(){
    _player1_power++;
    if(_player1_power == 4){
        _player1_power_ready = true;
        }
    if(_player1_power<5)
        Power_bar_P1.UpdatePowerBar(_player1_power);
    }

    public void Player_2Power_up(){
        _player2_power++;
    if(_player2_power == 4){
        _player2_power_ready = true;
        }
        if(_player2_power < 5)
        Power_bar_P2.UpdatePowerBar(_player2_power);
    }

    public void ClearPlayer1PowerBar(){
        _player1_power = -1;
        _player1_power_ready = false;
        Power_bar_P1.emptyPowerBar();
    }

    public void ClearPlayer2PowerBar(){
        _player2_power = -1;
        _player2_power_ready = false;
        Power_bar_P2.emptyPowerBar();
    }

   


    

}
