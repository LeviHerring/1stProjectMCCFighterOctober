using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isPlayerOne; 

    [SerializeField] GameObject dream;
    [SerializeField] GameObject fruitBerries;
    [SerializeField] GameObject peteZahHutt;
    [SerializeField] Transform playerOnePos;
    [SerializeField] Transform playerTwoPos; 


    // Start is called before the first frame update
    void Start()
    {
        string playerOne = PlayerPrefs.GetString("Player1");
        string playerTwo = PlayerPrefs.GetString("Player2");

        switch (playerOne)
        {
            case "Dream":
                dream.SetActive(true);
                dream.transform.position = playerOnePos.position;
                isPlayerOne = true; 
                break;

            case "FruitBerries":
                fruitBerries.SetActive(true);
                fruitBerries.transform.position = playerOnePos.position;
                isPlayerOne = true;
                break;

            case "PeteZahHutt":
                peteZahHutt.SetActive(true);
                peteZahHutt.transform.position = playerOnePos.position;
                isPlayerOne = true;
                break; 
        }

        switch (playerTwo)
        {
            case "Dream":
                dream.SetActive(true);
                dream.transform.position = playerTwoPos.position;
                isPlayerOne = false;
                break;

            case "FruitBerries":
                fruitBerries.SetActive(true);
                dream.transform.position = playerTwoPos.position;
                isPlayerOne = false;
                break;

            case "PeteZahHutt":
                peteZahHutt.SetActive(true);
                peteZahHutt.transform.position = playerTwoPos.position;
                isPlayerOne = false;
                break; 
        }

        int count = 0;

        foreach(PlayerController instance in FindObjectsOfType<PlayerController>())
        {
            if (count == 0)
            {
                instance.isPlayerOne = true; 
            }
            else
            {
                instance.isPlayerOne = false; 
            }
            count++; 
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
