using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2MovementSingle :Player_2Movement
{
  
        Transform t = GameObject.Find("Player_2Paddle").transform;
        float speed = GameObject.Find("Player_2Paddle").GetComponent<Player_2Paddle>().speed;
        Rigidbody2D _rigidbody = GameObject.Find("Player_2Paddle").GetComponent<Player_2Paddle>().GetRigidbody2D();
        Ball ball = GameObject.Find("Ball").GetComponent<Ball>();


    public  void  move(){
    
        
         if(ball.GetRigidbody2D().velocity.x > 0.0f)
        {
            if(ball.GetRigidbody2D().position.y > t.position.y){
                _rigidbody.AddForce(Vector2.up * speed);
            }
            else if(ball.GetRigidbody2D().position.y < t.position.y){
                _rigidbody.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if(t.position.y > 0.0f){
                _rigidbody.AddForce(Vector2.down * speed);
            }

             else if(t.position.y < 0.0f){
                _rigidbody.AddForce(Vector2.up* speed);
            }
        }
    }

    
}
