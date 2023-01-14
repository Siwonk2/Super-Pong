using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2Paddle : Paddle
{

    private Player_2Movement movement;


    public override void Awake()
    {
        _rigidbody =  GetComponent<Rigidbody2D>();
    }
    

    public void setMovement(Player_2Movement movementType){
        movement = movementType;
    }

    private void Update(){
        if(Manager.getPlayerSelectNumber() == 2){
            if(Input.GetKeyDown(KeyCode.M) && (ball.transform.position.x > 7.0f) && (ball.velocity.x > 0.0f) && Manager.get_Player_2_power_ready() == true)
                {
                    ball_obj.powerShot();
                    Manager.ClearPlayer2PowerBar();
                }
            }
         if(Manager.getPlayerSelectNumber() == 1){
            bool usePower = false;
            int random = Random.Range(0,100);
            if(random == 0){
                usePower = true;
            }
            if((ball.transform.position.x > 7.0f) && (ball.velocity.x > 0.0f) && Manager.get_Player_2_power_ready() == true && usePower){
                ball_obj.powerShot();
                Manager.ClearPlayer2PowerBar();
            }
         }
    }

     private void FixedUpdate(){
             if(Manager.getPlayerSelectNumber() == 2){
                 movement.move(); 
                if(_direction.sqrMagnitude != 0 ){
                    _rigidbody.AddForce(_direction * speed);
                }   
             }
             
        }

}
