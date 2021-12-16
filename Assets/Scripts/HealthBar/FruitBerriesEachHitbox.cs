using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBerriesEachHitbox : MonoBehaviour
{
    public float damage;

    HealthBar healthBar;



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
        if (collision.gameObject.tag == "Dream")
        {
            Debug.Log("Hit ON DREAM Detected");
            healthBar.GetCoins(damage);

        }
        else if (collision.gameObject.tag == "PeteZahHutt")
        {
            Debug.Log("Hit ON PETE Detected");
            healthBar.GetCoins(damage);
        }

    }
}