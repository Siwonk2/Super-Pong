using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
   public float bounceStrength;
   public float bounceStrengthMultiplier = 1;

   private bool opposeforce = false;


   private void OnCollisionEnter2D(Collision2D collision){
    Ball ball = collision.gameObject.GetComponent<Ball>();
   
    

    if(ball != null)
    { 
        if(ball.getPowerReady()&& tag == "Paddle"){
           bounceStrengthMultiplier = 5f; 
           ball.setPowerReadyFalse();
           ball.setIsPowerShot(true);
        }

        else if(ball.getIsPowerShot() && tag == "Paddle"){
           ball.setIsPowerShot(false);
           opposeforce = true;

        }
    
        Vector2 normal = collision.GetContact(0).normal;
        ball.addForce(-normal * this.bounceStrength*bounceStrengthMultiplier);
        bounceStrengthMultiplier = 1f;
        if(opposeforce == true){
        ball.addForce(0.5f*-ball.GetRigidbody2D().velocity * this.bounceStrength*bounceStrengthMultiplier);
        opposeforce = false;
        }
        
        
        if(tag == "Ceiling"){
            FindObjectOfType<AudioManager>().play("Bounce_Wall");
        }
        else if(tag == "Paddle"){
            FindObjectOfType<AudioManager>().play("Bounce_Paddle");
        }
        
    }

   }


   public void resetBounceSettings(){
    bounceStrengthMultiplier = 1f;
    opposeforce = false;
   }
}

