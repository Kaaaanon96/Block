using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	private float accel = 1000.0f;
	private Vector3 inputVector;
	private Rigidbody rig;

	// Use this for initialization
	void Start () {
		rig = this.GetComponent<Rigidbody>();
		inputVector = new Vector3(0.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
//		//力を加える
//		this.GetComponent<Rigidbody> ().AddForce (
//			transform.right * Input.GetAxisRaw ("Horizontal") * accel, 
//			ForceMode.Impulse);
		inputVector = transform.right * Input.GetAxisRaw("Horizontal") * accel;
	}

	void FixedUpdate(){
		//力を加える
		rig.AddForce(inputVector, ForceMode.Impulse);
	}
}
