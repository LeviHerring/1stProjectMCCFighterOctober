using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenuToPlay()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    public void MainMenuToHowToPlay()
    {
        SceneManager.LoadScene("Controls"); 
    }

    public void ToCharacterSelectScreen()
    {
        SceneManager.LoadScene("Character Select Screen");
    }
}
