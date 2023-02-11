using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Horse : MonoBehaviour
{
    //variables
    public int horse_stamina = 0;
    public int horse_speed = 0;
    public int money = 200;
    public TextMeshProUGUI stamina_txt;
    public TextMeshProUGUI speed_txt;
    public TextMeshProUGUI money_txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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

    public void startRace(){
        
    }
}
