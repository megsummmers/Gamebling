using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceControls : MonoBehaviour
{
    public HorseControls horseScript;
    public HorseStats playerhorse;
    //variables
    public bool start = false;
    //horse objects
    public GameObject horse1;
    public GameObject horse2;
    public GameObject horse3;
    public GameObject horse4;
    public GameObject horse5;
    public GameObject horse6;
    public GameObject horse7;
    public GameObject horseP;

    // Update is called once per frame
    void Update()
    {
       
    }

    public void horseFinished(){
        Debug.Log("horse done!");
    }

    public void startGame(){
        horseP.GetComponent<HorseControls>().stamina = playerhorse.horse_stamina;
        horseP.GetComponent<HorseControls>().setSpeed = playerhorse.horse_speed;
        horseP.GetComponent<HorseControls>().speed = playerhorse.horse_speed;

        horse1.GetComponent<HorseControls>().start = true;
        horse2.GetComponent<HorseControls>().start = true;
        horse3.GetComponent<HorseControls>().start = true;
        horse4.GetComponent<HorseControls>().start = true;
        horse5.GetComponent<HorseControls>().start = true;
        horse6.GetComponent<HorseControls>().start = true;
        horse7.GetComponent<HorseControls>().start = true;
        horseP.GetComponent<HorseControls>().start = true;
    }
}
