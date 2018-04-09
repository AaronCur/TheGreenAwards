using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DesertDestroyByContact : MonoBehaviour {
    private int oil;
    public Text oilText;
    public string sceneNew;
    public AudioSource pickUpAudioSource;   //found at https://www.freesound.org/s/345299/
    public AudioSource levelCompleteAudioSource;     //found at https://www.freesound.org/s/274182/
    private int timer;
    private Rect rect;      //rectangle for the size of the screen
    public Texture2D image;     //the loading image for the next scene

    // Use this for initialization
    void Start()
    {
        oil = 0;
        SetCountText();
        timer = 1;            //larger number larger loadtime
        rect = new Rect(0, 0, Screen.width, Screen.height);     //sets the screen size to rect
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("oil"))
        {
            other.gameObject.SetActive(false);
            oil = oil + 1;
            SetCountText();
            if (oil < 5)
            {
                pickUpAudioSource.Play();
            }

            if (oil >= 5)
            {
                levelCompleteAudioSource.Play();

                if (timer > 0)
                {
                    timer--;
                }
                if (timer == 0)
                {
                    SceneManager.LoadScene(sceneNew);    //when the timer is done load the new scene
                }

            }
        }
    }

    void SetCountText()
    {
        oilText.text = "Fuel: " + oil.ToString() + " / 5";
    }
    void OnGUI()
    {
        if (oil >= 5)
        {
            GUI.DrawTexture(rect, image, ScaleMode.StretchToFill);      //if all the collectables are collected display the loading screen image
        }
    }
}

