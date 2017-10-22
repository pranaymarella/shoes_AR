using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUICode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI() {
		GUI.Box (new Rect (10, 10, 100, 90), "GUI.Box");
		if (GUI.Button (new Rect (20, 40, 80, 20), "Button1")) {
			Debug.Log ("Button1 is pressed");
		}
	}
}
