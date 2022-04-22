using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyCar : MonoBehaviour
{
    public float money;
    public GameObject[] Cars;
    public GameObject Panel;
    public bool c1, c2, c3, c4;
    public Text YellowCarPrice, GrayCarPrice, BlueCarPrice, BlackCarPrice;
    public Transform Spawn;
    public Text NumberOfGold;
    void Start()
    {
        
    }

    
    void Update()
    {
        NumberOfGold.text = "Coin:" + money;
        if(Input.GetKeyDown(KeyCode.B)){
            Panel.SetActive(true);
        }
    }
    public void RedCar(){
        for (int i = 0 ; i < Cars.Length;i++ ){
            Cars[i].SetActive(false);
            Cars[0].SetActive(true);
            Cars[0].transform.position = Spawn.transform.position;
            Panel.SetActive(false);
        }

    }

    public void YellowCar(){
        if(money >= 200 || c1){
            if(!c1){
                money -= 200;
            }
            for (int i = 0 ; i < Cars.Length;i++ ){
                Cars[i].SetActive(false);
                Cars[1].SetActive(true);
                Panel.SetActive(false);
                c1 = true;
                Cars[1].transform.position = Spawn.transform.position;
                YellowCarPrice.text = ("Seç");
            }
        }
    }    
    public void GrayCar(){
        if(money >= 400 || c2){
            if(!c2){
                money -= 400;
            }
            
            for (int i = 0 ; i < Cars.Length;i++ ){
                Cars[i].SetActive(false);
                Cars[2].SetActive(true);
                Panel.SetActive(false);
                c2 = true;
                Cars[2].transform.position = Spawn.transform.position;
                GrayCarPrice.text = ("Seç");
            }
        }
    }    
    public void BlueCar(){
        if(money >= 600 || c3){
            if(!c3){
                money -= 600;
            }
            
            for (int i = 0 ; i < Cars.Length;i++ ){
                Cars[i].SetActive(false);
                Cars[3].SetActive(true);
                Panel.SetActive(false);
                c3 = true;
                Cars[3].transform.position = Spawn.transform.position;
                BlueCarPrice.text = ("Seç");
            }
        }
    } 
    public void BlackCar(){
        if(money >= 800 || c4){
            if(!c4){
                money -= 800;
            }
            
            for (int i = 0 ; i < Cars.Length;i++ ){
                Cars[i].SetActive(false);
                Cars[4].SetActive(true);
                Panel.SetActive(false);
                c4 = true;
                Cars[4].transform.position = Spawn.transform.position;
                BlackCarPrice.text =("Seç");
            }
        }
    }       
}
