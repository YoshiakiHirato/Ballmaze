using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	[SerializeField]
	private float moveSpeed;
	[SerializeField]
	private float rotateSpeed;
	private Rigidbody playerRigidbody;
	// Use this for initialization
	void Start () {
		playerRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Turn ();
	}

	void Move(){
		float v=Input.GetAxis("Vertical");
		Vector3 movement = transform.forward * v * moveSpeed * Time.deltaTime;
		playerRigidbody.MovePosition (playerRigidbody.position + movement);
	}

	void Turn(){
		if(Input.GetKeyDown("right")){
			transform.Rotate(new Vector3(0,rotateSpeed,0));
		}
		if (Input.GetKeyDown ("left")) {
			transform.Rotate (new Vector3 (0,-rotateSpeed,0));
		}
	}
}
