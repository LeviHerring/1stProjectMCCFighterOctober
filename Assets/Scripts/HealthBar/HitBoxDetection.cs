using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxDetection : MonoBehaviour
{


    HealthBar healthbar; 

    [SerializeField]
    GameObject ownHtibox; 
    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<HealthBar>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == ownHtibox)
        {
            GetComponent<HealthBar>().GetCoins(0f);
        }
        if (collision.gameObject.name == "FruitBerriesTemplate_0")
        {
            Debug.Log("Hit Detected");
            GetComponent<HealthBar>().GetCoins(0.001f);
            
        }
    }
}
