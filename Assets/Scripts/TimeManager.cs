using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {
	public Text timeText;
	[SerializeField]
	private Goal goal;
	public int minutes;
	public float seconds;
	[SerializeField]
	private Text setumeiText;
	void Start () {
		setumeiText.text = "Press Space to view from the top!!";
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale > 0 && goal.isClear == false) {
			seconds += Time.deltaTime;
			if(seconds >= 60.0f) {
				minutes++;
				seconds = seconds - 60;
			}
	}
		timeText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00");
		if (goal.isClear) {
			timeText.text = null;
		}
		if(seconds==30){
			setumeiText.text = null;
		}
	}
}
