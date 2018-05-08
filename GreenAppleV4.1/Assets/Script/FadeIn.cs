using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour {

	public float minimum = 0.0f;
	         public float maximum = 1f;
	         public float duration = 3.0f;
	         private float startTime;
	         public SpriteRenderer sprite;

	         void Start() {
	             startTime = Time.time;
	         }
	         void Update() {
	             float t = (Time.time - startTime) / duration;
							 float alpha = Mathf.SmoothStep(minimum, maximum, t);
	             sprite.color = new Color(1f,1f,1f,alpha);

							 if( alpha == 1)
							 {
								 SceneManager.LoadScene(1);
							 }
						 }
}
