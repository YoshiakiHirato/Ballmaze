using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal: MonoBehaviour {
	public bool isClear = false;

	void OnTriggerEnter(Collider other){
		isClear = true;

	}
}