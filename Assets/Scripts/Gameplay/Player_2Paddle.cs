using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2Paddle : Paddle
{

    private Player_2Movement movement;

    private int frames = 0;

    public override void Awake()
    {
        _rigidbody =  GetComponent<Rigidbody2D>();
    }
    

    public void setMovement(Player_2Movement movementType){
        movement = movementType;
    }

    private void Update(){
         if(Input.GetKeyDown(KeyCode.M) && (ball.transform.position.x > 7.0f) && (ball.velocity.x > 0.0f) && Manager.get_Player_2_power_ready() == true)
                    {
                        ball_obj.powerShot();
                        Manager.ClearPlayer2PowerBar();
                    }
    }

     private void FixedUpdate(){
        
             movement.move();  
             if(Manager.getPlayerSelectNumber() == 2){
                if(_direction.sqrMagnitude != 0 ){
                    _rigidbody.AddForce(_direction * speed);
                }   
             }
        }

}
