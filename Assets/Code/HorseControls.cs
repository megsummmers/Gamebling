using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseControls : MonoBehaviour
{
    public HorseStats playerhorse;
    public RaceControls raceScript;
    //variables
    public bool start = false;
    public float stamina = 8;
    public int setSpeed = 40;
    public int speed;
    float timer = 0;

    void Start() {
        speed = setSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //create timer
        timer += Time.deltaTime;
        //run from -150 to 500 in canvas 810 to 1460
        if (transform.position.x <= 1460 && start){
            transform.Translate(Vector3.right * (Time.deltaTime * speed));
        } else { //reset speed
            speed = setSpeed;
            raceScript.horseFinished();
            Debug.Log("sent");
        }
        //check if stamina starts affecting the horses 
        if (timer >= stamina && speed >= 25){
            speed -= 5;
            stamina += 3;
        }
    }
}
