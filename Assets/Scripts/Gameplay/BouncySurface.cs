using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
   public float bounceStrength;

   private void OnCollisionEnter2D(Collision2D collision){
    Ball ball = collision.gameObject.GetComponent<Ball>();
    
    

    if(ball != null)
    { 
        Vector2 normal = collision.GetContact(0).normal;
        ball.addForce(-normal * this.bounceStrength);
        if(tag == "Ceiling"){
            Debug.Log("yo");
            FindObjectOfType<AudioManager>().play("Bounce_Wall");
        }
        else if(tag == "Paddle"){
            Debug.Log("yo");
            FindObjectOfType<AudioManager>().play("Bounce_Paddle");
        }
        
    }

   }
}

