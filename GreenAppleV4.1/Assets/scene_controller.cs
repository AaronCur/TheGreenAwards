using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// Loads scene with index of 1
    /// The main Game scene
    /// Public function accessed from
    /// UI button OnClick() event.
    /// </summary>
    public void GoToGame()
    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Quits the current Unity application
    /// closing the .exe
    /// Public function accessed from UI
    /// function OnClick event.
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
