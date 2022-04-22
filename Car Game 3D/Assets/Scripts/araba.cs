using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba : MonoBehaviour
{
    public WheelCollider FrontLeftWheel, FrontRightWheel, RearLeftWheel, RearRightWheel;
    public float motorhızı,dönmehızı;
    public GameObject Coin;
    public int coins;
    public Transform sp1,sp2,sp3;
    public GameObject Panel;
    public GameObject Body;



    BuyCar market;
       void Start(){
           InvokeRepeating("klonla",0.5f,5.0f);
    }
       void Update()
    {
            
            //if( Body.transform.position.y > 1.5f) {
                
              //  Panel.SetActive(true);
            //}
                

        RearRightWheel.motorTorque = motorhızı * Input.GetAxis("Vertical");
        RearLeftWheel.motorTorque = motorhızı * Input.GetAxis("Vertical");
        FrontRightWheel.steerAngle = dönmehızı * Input.GetAxis("Horizontal");   
        FrontLeftWheel.steerAngle = dönmehızı * Input.GetAxis("Horizontal");
    }

    public void klonla(){

                Vector3 position1 = new Vector3(1.0f, 3.5f, Random.Range(28.0f,40.0f));
                Vector3 position2 = new Vector3(8.0f, 3.5f, Random.Range(40.0f,55.0f));
                Vector3 position3 = new Vector3(16.0f, 3.5f, Random.Range(55.0f,100.0f));

                 GameObject coinnobj1 = Instantiate(Coin, position1, Quaternion.identity);
                 GameObject coinnobj2 = Instantiate(Coin, position2, Quaternion.identity);
                 GameObject coinnobj3 = Instantiate(Coin, position3, Quaternion.identity);
             }
     
    
    public void OnTriggerEnter(Collider Col){
        if(Col.gameObject.tag == "coin"){
            coins = coins +100;
            Col.gameObject.SetActive(false);
            market = GameObject.FindGameObjectWithTag("money").GetComponent<BuyCar>();
            market.money += 100; 
            Destroy(Col.transform.gameObject);
        }
    }
}
