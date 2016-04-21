using UnityEngine;
using System.Collections;

public class starterManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("First") < 1) {
			PlayerPrefs.SetInt ("First", 1);
		} else {

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
