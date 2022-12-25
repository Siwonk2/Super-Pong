using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2MovementMultiplayer : Player_2Movement
{
        Transform t = GameObject.Find("Player_2Paddle").transform;
        float speed = GameObject.Find("Player_2Paddle").GetComponent<Player_2Paddle>().speed;
        Rigidbody2D _rigidbody = GameObject.Find("Player_2Paddle").GetComponent<Player_2Paddle>().GetRigidbody2D();
        Ball ball = GameObject.Find("Ball").GetComponent<Ball>();
        GameManager Manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    public void move(){
        if(Input.GetKey(KeyCode.UpArrow)){
            GameObject.Find("Player_2Paddle").GetComponent<Player_2Paddle>().setDirection(Vector2.up);
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            GameObject.Find("Player_2Paddle").GetComponent<Player_2Paddle>().setDirection(Vector2.down);
        }
        else{
            GameObject.Find("Player_2Paddle").GetComponent<Player_2Paddle>().setDirection(Vector2.zero);
        }

    }
}

