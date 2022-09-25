using UnityEngine;

public class Player_2Paddle : Paddle
{
    public Rigidbody2D ball;

    public GameManager Manager;

    private int PlayerNumber;

    


    public override void Awake(){
        _rigidbody =  GetComponent<Rigidbody2D>();
       PlayerNumber = Manager.getPlayerSelectNumber();
       if(PlayerNumber == 1){
        _rigidbody.mass = 0.2f;
        _rigidbody.drag = 3;
       }
    }
    private void FixedUpdate()
    {
        if(PlayerNumber == 2){
            if(_direction.sqrMagnitude != 0 ){
            _rigidbody.AddForce(_direction * speed);
            }
        }
        else{
        if(this.ball.velocity.x > 0.0f)
        {
            if(this.ball.position.y > this.transform.position.y){
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if(this.ball.position.y < this.transform.position.y){
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            if(this.transform.position.y > 0.0f){
                _rigidbody.AddForce(Vector2.down * this.speed);
            }

             else if(this.transform.position.y < 0.0f){
                _rigidbody.AddForce(Vector2.up* this.speed);
            }
        }
    }
}

   private void Update(){
    if(Manager.getPlayerSelectNumber()==2){

        if(Input.GetKey(KeyCode.UpArrow)){
            _direction = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            _direction = Vector2.down;
        }
        else{
            _direction = Vector2.zero;
        }
    } 
   }
}
