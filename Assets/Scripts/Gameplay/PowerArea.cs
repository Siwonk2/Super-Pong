using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PowerArea : MonoBehaviour
{
    public EventTrigger.TriggerEvent power_bar;
    private void OnCollisionEnter2D(Collision2D collision){
    Ball ball = collision.gameObject.GetComponent<Ball>();

    if(ball != null)
    {
       BaseEventData eventData = new BaseEventData(EventSystem.current);
       this.power_bar.Invoke(eventData);

    }

   }
}
