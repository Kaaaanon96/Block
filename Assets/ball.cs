using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	//　初期スピード
	private float speed = 15.0f;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().AddForce(
			(transform.forward + transform.right) * speed,
			ForceMode.VelocityChange);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
