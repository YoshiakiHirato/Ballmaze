using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	[SerializeField]
	private Text scoreText;
	[SerializeField]
	private Text lastscoreText;
	[SerializeField]
	private Goal goal;
	public static float score=0;
	[SerializeField]
	private TimeManager time;
	private float timescore;
	[SerializeField]
	private Text timescoreText;
	[SerializeField]
	private Text resultScoreText;
	[SerializeField]
	private GameManager gameManager;
	private float lastscore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = score.ToString();
		if (gameManager.n == 1) {
			scoreText.text = null;
			timescore = 1000 - (time.seconds + 60 * time.minutes) * 8;
			lastscore = timescore + score;
			timescoreText.text = "時間ボーナス"+timescore.ToString("000");
			resultScoreText.text = "コインボーナス"+score.ToString();
			lastscoreText.text = "スコア" + lastscore.ToString("000");


		}

	}
}
