using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseControls : MonoBehaviour
{
    public GameObject raceScript;
    //variables
    [SerializeField] private int horseNum;
    public bool start = false;
    public float setStamina = 8;
    public int setSpeed = 40;
    public int speed;
    public float stamina;
    public float startPosX;
    public float startPosY;
    public float startPosZ;
    public float endPos;
    float timer = 0;

    public GameObject raceEnd;

    void Start() {
        speed = setSpeed;
        stamina = setStamina;
        startPosX = transform.position.x;
        startPosY = transform.position.y;
        startPosZ = transform.position.z;
        endPos = raceEnd.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

        //create timer
        if (start){
            timer += Time.deltaTime;
        }
        //run from -150 to 500 in canvas 810 to 1460
        if (transform.position.x < endPos && start){
            transform.Translate(Vector3.right * (Time.deltaTime * speed));
        } else if (transform.position.x >= endPos && start) { //reset speed
            speed = setSpeed;
            raceScript.GetComponent<RaceControls>().finishedLine(horseNum);
            start = false;
        }
        //check if stamina starts affecting the horses 
        if (timer >= stamina && speed >= 25){
            speed -= 5;
            stamina += 4;
        }
    }

    public void reset(){
        transform.position = new Vector3(startPosX, startPosY, startPosZ);
        speed = setSpeed;
        stamina = setStamina;
        timer = 0;
        start = false;
    }
}