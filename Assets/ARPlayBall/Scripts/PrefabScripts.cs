using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScripts : MonoBehaviour {
	public GameObject ball2;
	GameObject clone;
	//public Rigidbody rgd;
	// Use this for initialization
	void Update () {
			clone = Instantiate (ball2, transform.position, Quaternion.identity) as GameObject;
		
	}
	void Copy(){
		

	}
}
