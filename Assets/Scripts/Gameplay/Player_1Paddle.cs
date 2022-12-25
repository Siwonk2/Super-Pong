
using UnityEngine;

public class Player_1Paddle : Paddle
{
   public override void Awake()
    {
        _rigidbody =  GetComponent<Rigidbody2D>();
    }
    
    private void Update(){
        if(Input.GetKey(KeyCode.W)){
            _direction = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.S)){
            _direction = Vector2.down;
        }
        else{
            _direction = Vector2.zero;
        }

        if(Input.GetKeyDown(KeyCode.P) && (ball.transform.position.x < -7.0f) && (ball.velocity.x < 0.0f) && Manager.get_Player_1_power_ready() == true)
            {
                ball_obj.powerShot();
                Manager.ClearPlayer1PowerBar();
            }
    } 

    private void FixedUpdate(){
        
        if(_direction.sqrMagnitude != 0 ){
            _rigidbody.AddForce(_direction * speed);
        }
    }
}
