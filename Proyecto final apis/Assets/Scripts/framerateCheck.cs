using UnityEngine;
using System.Text;
using UnityEngine.UI;
using System.Collections;

public class framerateCheck : MonoBehaviour {

	Text fps;

	// Use this for initialization
	void Start () {
		fps = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		fps.text = "" + (int)(1.0f / Time.smoothDeltaTime);
	}


}
