using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
	
public class Coin : MonoBehaviour {
	[SerializeField]
	private float rotateSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 1*rotateSpeed, 0);
	}

	void OnTriggerEnter(Collider obj){
		ScoreManager.score += 100;
		Destroy (this.gameObject);
	}
}



