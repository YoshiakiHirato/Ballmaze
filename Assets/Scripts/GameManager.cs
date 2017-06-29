using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	[SerializeField]
	private GameObject playerPrefab;
	[SerializeField]
	private GameObject ResultPrefab;
	[SerializeField]
	private Transform startPoint;
	[SerializeField]
	private Goal goal;
	[SerializeField]
	private Text GoalText;
	[SerializeField]
	private Material rismat;
	public int n=0;
	void Start () {
		Instantiate (playerPrefab,startPoint.position,startPoint.rotation);
		//プレイヤー生成
		rismat.SetColor ("_Color",new Color (0.95f,0.95f,0.95f,0));

	}

	void Update ()
	{
		if (goal.isClear) {
			StartCoroutine ("ResultPhase");//結果表示
		}
	}

	private IEnumerator ResultPhase(){
		GoalText.text="GOAL!!";
		yield return new WaitForSeconds (2.0f);
		n++;
		Result();
	}

	void Result(){
		rismat.SetColor ("_Color",new Color (0.7f,0.7f,0.7f,0.4f));
		if (Input.GetKeyDown (KeyCode.Space)) {
			SceneManager.LoadScene ("StageSelect");
		}
	}
	}

