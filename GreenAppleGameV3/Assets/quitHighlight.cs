using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;


using UnityEngine.Events;
using UnityEngine.EventSystems;


public class quitHighlight : MonoBehaviour, IPointerEnterHandler
{

    int quitRemaining = 2;
    public Button button;

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Application.Quit();
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        ColorBlock colorVar = button.colors;
        print("Quitting Game : " + quitRemaining);
        quitRemaining--;

        if (quitRemaining == 1)
        {
            colorVar.highlightedColor = new Color(255, 0, 0);//Red
            button.colors = colorVar;

            colorVar.normalColor = new Color(255, 0, 0);
            button.colors = colorVar;

            StartCoroutine(ExecuteAfterTime(0.5f));

        }
    }

}