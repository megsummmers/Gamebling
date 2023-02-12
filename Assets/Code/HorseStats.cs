using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HorseStats : MonoBehaviour
{
    //ref other scripts
    public RaceControls raceScript;
    //variables
    public int horse_stamina = 0;
    int calc_stamina = 2;
    public int horse_speed = 0;
    int calc_speed = 25;
    public int money = 200;
    public TextMeshProUGUI stamina_txt;
    public TextMeshProUGUI speed_txt;
    public TextMeshProUGUI money_txt;

    public GameObject camera;
    public GameObject competitionUI;
    public GameObject trainingUI;

    // Update is called once per frame
    void Update()
    {
        stamina_txt.text = horse_stamina.ToString();
        speed_txt.text = horse_speed.ToString();
        money_txt.text = money.ToString();
    }

    public void increaseSpeed(){
        if(horse_speed <= 9 && money >= 100){
            horse_speed += 1;
            money -= 100;
        } else if (money <= 100) {
            Debug.Log("not enough money");
        } else if (horse_speed == 10){
            Debug.Log("max speed");
        }
    }

    public void increaseStamina(){
        if(horse_stamina <= 9 && money >= 100){
            horse_stamina += 1;
            money -= 100;
        } else if (money <= 100) {
            Debug.Log("not enough money");
        } else if (horse_stamina == 10){
            Debug.Log("max stamina");
        }
    }

    public void compete(){
        calc_speed += horse_speed * 2;
        calc_stamina += horse_stamina;
        raceScript.p_stamina = calc_stamina;
        raceScript.p_speed = calc_speed;
        //rotate camera
        camera.transform.Rotate(0, 180.0f, 0);
        competitionUI.SetActive(true);
        trainingUI.SetActive(false);
    }
}
