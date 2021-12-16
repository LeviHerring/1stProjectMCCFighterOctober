using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using System;

public class FruitBerriesHitBox : MonoBehaviour
{


    HealthBar healthBar;



    [SerializeField]
    GameObject ownHtibox;
    // Start is called before the first frame update
    void Start()
    {
        GameObject fruitBerries = GameObject.Find("FruitBerries"); //null for some reason??
        healthBar = fruitBerries.GetComponent<HealthBar>(); //null for some reason?? 




    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PeteZahHuttTemplate_0")
        {
            Debug.Log("Hit ON PETE Detected");
            healthBar.GetCoins(0.0000000000000000000001f);
        }
        else if (collision.gameObject.name == "PeteZahHutt")
        {
            Debug.Log("HIT ON DREAM AAAAAAAAAA");
            healthBar.GetCoins(1f);
        }
    }
}
