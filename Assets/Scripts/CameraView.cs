using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour {
	[SerializeField]
	private Camera mainCamera;//メインカメラ
	[SerializeField]
	private Camera highCamera;//サブのカメラです
	void Start (){

	}

	void Update () {
		// Spaceキーで切り替え
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine ("ChangeCamera");
		}
		} 
	private IEnumerator ChangeCamera(){
		highCamera.depth = 2;
			yield return new WaitForSeconds (5.0f);
		highCamera.depth = 0;
		}
	}
	