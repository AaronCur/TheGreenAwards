using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Events;
using UnityEngine.EventSystems;

using UnityEngine.SceneManagement;



public class startHightlight : MonoBehaviour, IPointerEnterHandler
{

    int startRemaining = 2;
    public string game;
    public Button button;

    public GameObject loadingScreen;
    public Text loadingText;
    public GvrViewer head;


    int loadingTimer = 1;

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        LoadingScreen();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ColorBlock colorVar = button.colors;
        print("Starting Game : " + startRemaining);
        startRemaining--;

        if (startRemaining == 1)
        {
            colorVar.highlightedColor = new Color(0, 255, 0);//Green
            button.colors = colorVar;

            colorVar.normalColor = new Color(0, 255, 0);
            button.colors = colorVar;

            StartCoroutine(ExecuteAfterTime(0.5f));
        }
    }

    public void LoadingScreen()
    {
        head.Recenter();

        loadingScreen.SetActive(true);
        loadingText.gameObject.SetActive(true);
        button.gameObject.SetActive(false);
       
        loadingTimer--;
        print("Loading : " + loadingTimer);

        if (loadingTimer <= 0)
        {
           // SceneManager.LoadScene(game);
        }
    }

}