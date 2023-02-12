using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceControls : MonoBehaviour
{
    public HorseStats playerHorse;
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
    public int p_stamina;
    public int p_speed;
    public bool sent = false;

    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
        if(sent){
            Debug.Log(p_speed + " " + p_stamina);
        }
    }

    public void finishedLine(){
        ranking.Add(horseFinished);
        if (ranking.Count == 8){
            var rankArray = ranking.ToArray();
            for (int i = 0; i < rankArray.Length; i++){
                if(rankArray[i] == 0){
                    if(i >= 4){
                        playerHorse.money += 35;
                    } else if (i == 3){
                        playerHorse.money += 75;
                    } else if (i == 2){
                        playerHorse.money += 150;
                    } else if (i == 1){
                        playerHorse.money += 300;
                    }
                }
            }
        }
    }

    public void startGame(){
        horseP.GetComponent<HorseControls>().stamina += p_stamina;
        horseP.GetComponent<HorseControls>().setSpeed += p_speed;
        horseP.GetComponent<HorseControls>().speed += p_speed;

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


