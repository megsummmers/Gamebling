using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceControls : MonoBehaviour
{
    public GameObject playerHorse;
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
    public int horseFinished;
    public static List<int> ranking = new List<int>();
    //player horse stats
    public float p_stamina;
    public int p_speed;
    public bool sent = false;
    //camera things
    public GameObject camera;
    public GameObject competitionUI;
    public GameObject trainingUI;
    //info tabs
    public GameObject staminaInfo;
    public GameObject speedInfo;

    void Start(){
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void finishedLine(int horseNum){
        horseFinished = horseNum;
        ranking.Add(horseNum);
        if (ranking.Count == 8){
            var rankArray = ranking.ToArray();
            for (int i = 0; i < rankArray.Length; i++){
                Debug.Log(i + " place, horse " + rankArray[i]);
                if(rankArray[i] == 8){
                    if(i >= 4){
                        playerHorse.GetComponent<HorseStats>().money += 35;
                    } else if (i == 3){
                        playerHorse.GetComponent<HorseStats>().money += 100;
                    } else if (i == 2){
                        playerHorse.GetComponent<HorseStats>().money += 150;
                    } else if (i == 1){
                        playerHorse.GetComponent<HorseStats>().money += 300;
                    }
                }
            }
            horse1.GetComponent<HorseControls>().reset();
            horse2.GetComponent<HorseControls>().reset();
            horse3.GetComponent<HorseControls>().reset();
            horse4.GetComponent<HorseControls>().reset();
            horse5.GetComponent<HorseControls>().reset();
            horse6.GetComponent<HorseControls>().reset();
            horse7.GetComponent<HorseControls>().reset();
            horseP.GetComponent<HorseControls>().reset();
            ranking.Clear();
        }
    }

    public void returnTraining(){
        //rotate camera
        camera.transform.Rotate(0, 180.0f, 0);
        competitionUI.SetActive(false);
        trainingUI.SetActive(true);
    }

    public void startGame(){
        Debug.Log("started");
        horseP.GetComponent<HorseControls>().stamina = p_stamina;
        horseP.GetComponent<HorseControls>().setSpeed = p_speed;
        horseP.GetComponent<HorseControls>().speed = p_speed;
        Debug.Log(p_speed + ", " + p_stamina);
        horse1.GetComponent<HorseControls>().start = true;
        horse2.GetComponent<HorseControls>().start = true;
        horse3.GetComponent<HorseControls>().start = true;
        horse4.GetComponent<HorseControls>().start = true;
        horse5.GetComponent<HorseControls>().start = true;
        horse6.GetComponent<HorseControls>().start = true;
        horse7.GetComponent<HorseControls>().start = true;
        horseP.GetComponent<HorseControls>().start = true;
    }

    public void stHoverOn(){
        staminaInfo.SetActive(true);
    }

    public void stHoverOff(){
        staminaInfo.SetActive(false);
    }

    public void spHoverOn(){
        speedInfo.SetActive(true);
    }

    public void spHoverOff(){
        speedInfo.SetActive(false);
    }
}


