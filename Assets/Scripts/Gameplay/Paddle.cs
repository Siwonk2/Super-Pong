
using UnityEngine;

public abstract class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    protected Vector2 _direction;

    public GameManager Manager;

    public Rigidbody2D ball;

     public Ball ball_obj;
    public float speed = 5.0f;

    public abstract void Awake();


    public bool makeActive = false;
   

    public void ResetPosition(){
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector3.zero;
    }

    public void setDirection(Vector2 v){
        this._direction = v;
    }

    public Rigidbody2D GetRigidbody2D(){
        return _rigidbody;
    }
}
