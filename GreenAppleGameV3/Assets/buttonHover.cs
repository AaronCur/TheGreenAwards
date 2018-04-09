using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonHover : MonoBehaviour {

    public int quitRemaining = 100;
    public int startRemaining = 100;
    public string game;

    public GameObject starButton;
    public GameObject quitButton;

    void Update()
    {
        //if the quit button is not active then this must mean the start button is being selected
        //the game waits a few seconds before launching the game
        if(!quitButton.activeSelf)
        {
            startRemaining--;
            if(startRemaining <= 0)
            {
                SceneManager.LoadScene(game);
            }
      
        }

        //if the start button is not active then this must mean the quit button is being selected
        //the game waits a few seconds before shutting down the application
        else if (!starButton.activeSelf)
        {
            quitRemaining--;
            if (quitRemaining <= 0)
            {
                Application.Quit();
            }

        }
    }

   
}