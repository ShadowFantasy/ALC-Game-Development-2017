﻿using UnityEngine;
using System.Collections;

public class GhostStun : MonoBehaviour {

	bool lightCheck;

	// Use this for initialization

	void Start () {
		lightCheck = GetComponent<FlashLight>().lightOn;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider other) {
		
		if(other.gameObject.name == "Ghost" && lightCheck)
			print("Ghost is Stunned!");
	}
}
