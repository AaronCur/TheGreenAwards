using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    float time;

        
    
    
      
    
    // Use this for initialization
    void Start () {
    time = 30;
}
	
	// Update is called once per frame
	void Update () {

    if (time > 0)
    {
        time -= Time.deltaTime;
    }
    else
    {
            SceneManager.LoadScene("Menu");
            time = 30;
    }
}
}
