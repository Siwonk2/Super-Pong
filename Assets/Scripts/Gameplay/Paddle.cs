
using UnityEngine;

public abstract class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    protected Vector2 _direction;
    public float speed = 10.0f;

    public abstract void Awake();
   

    public void ResetPosition(){
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
        _rigidbody.velocity = Vector3.zero;
    }
}
