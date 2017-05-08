// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour {

	public int StartTime;
	private float Counter;

	public Text CountDown;
	public Image ResultsBackground;
	public Text Results1;
	public Text Results2;

	// Use this for initialization
	void Start () {
		Counter = StartTime;
	}
	
	// Update is called once per frame
	void Update () {
		Counter -= Time.deltaTime;
		if (Counter < 0)
		{
			CountDown.text = "Round Over";
			Time.timeScale = 0;
			ResultsBackground.transform.localScale = new Vector3(1,1,1);
		}
		else
		{
			CountDown.text = Counter.ToString("F1");

		}

	}
			
}

