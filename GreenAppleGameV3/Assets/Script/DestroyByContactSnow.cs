using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyByContactSnow : MonoBehaviour {
    private int part;
    public Text appleText;
    //public string sceneNew;
    public AudioSource pickUpAudioSource;   //found at https://www.freesound.org/s/345299/
    public AudioSource levelCompleteAudioSource;     //found at https://www.freesound.org/s/274182/
    private int timer;
    private Rect rect;      //rectangle for the size of the screen
    public Texture2D image;     //the loading image for the next scene

    // Use this for initialization
    void Start()
    {
        part = 0;
        SetCountText();
        timer = 1;            //larger number larger loadtime
        rect = new Rect(0, 0, Screen.width, Screen.height);     //sets the screen size to rect
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("part"))
        {
            other.gameObject.SetActive(false);
            part = part + 1;
            SetCountText();
            if (part < 3)
            {
                pickUpAudioSource.Play();
            }

            if (part >= 3)
            {
               // levelCompleteAudioSource.Play();
               // SceneManager.LoadScene(sceneNew);
                    if (timer > 0)
                    {
                        timer--;
                    }
                    if (timer == 250)
                    {
                        levelCompleteAudioSource.Play();        //was in the code :)
                    }
                    if (timer == 0)
                    {
                        SceneManager.LoadScene("demoScene");      //when the timer is done load the new scene
                    }
            }
        }
    }

    void SetCountText()
    {
        appleText.text = "Parts: " + part.ToString() + " / 3";
    }
    void OnGUI()
    {
        if (part >= 3)
        {
            GUI.DrawTexture(rect, image, ScaleMode.StretchToFill);      //if all the collectables are collected display the loading screen image
        }
    }
}


