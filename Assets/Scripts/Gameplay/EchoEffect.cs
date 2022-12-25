using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{

    public float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject echo;

    private void Awake(){
        echo.SetActive(true);
    }

     private void Update(){

        if(timeBtwSpawns<=0){
            GameObject instance = Instantiate(echo,transform.position,Quaternion.identity);
            Destroy(instance,1f);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else{
            timeBtwSpawns -= Time.deltaTime;
        }
     }
}
