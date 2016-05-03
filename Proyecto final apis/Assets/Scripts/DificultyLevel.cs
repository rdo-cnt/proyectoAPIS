using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DificultyLevel : MonoBehaviour {

	public Text Mult;
	public float multiplier;

	// Use this for initialization
	void Start () {
		Mult = GetComponent<Text> ();
		multiplier = PlayerPrefs.GetFloat ("Multi");
	}
	
	// Update is called once per frame
	void Update () {
		Mult.text = multiplier.ToString ();
	}

	public void Change() {

		if (multiplier == 1.0f) {
			multiplier = 1.5f;
		} else {
			if (multiplier == 1.5f) {
				multiplier = 2.0f;
			} else {
				if (multiplier == 2.0f) {
					multiplier = 0.75f;
				} else {
					multiplier = 1.0f;
				}
			}
		}
		PlayerPrefs.SetFloat ("Multi", multiplier);
		PlayerPrefs.Save ();
	}


}
