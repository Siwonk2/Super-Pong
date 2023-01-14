using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class MoveToBallAgent : Agent{

    [SerializeField] private Transform TargetTransfrom;

    [SerializeField] private  Rigidbody2D TargetVelocity;
    [SerializeField] private Ball ball;
    [SerializeField] private Rigidbody2D _rigidBody ;


    
    public override void OnActionReceived(ActionBuffers actions)
    {
      
        float movePaddle = actions.DiscreteActions[0];
        float moveSpeed = 5.0f;
        if(movePaddle == 0){
            _rigidBody.AddForce(new Vector2(0.0f,1)*moveSpeed);
        }
        else if(movePaddle == 1){
            _rigidBody.AddForce(new Vector2(0.0f,0)*moveSpeed);
        }
        else if(movePaddle == 2){
            _rigidBody.AddForce(new Vector2(0.0f,-1)*moveSpeed);
        }

    }

    public override void CollectObservations(VectorSensor sensor)
    {   
        if(transform!=null || TargetTransfrom!=null){
        sensor.AddObservation(transform.position);
        sensor.AddObservation(TargetTransfrom.position);
        }
    }


}
