using UnityEngine;
using System.Collections;

public class LockLvl3Manager : MonoBehaviour {

	public GameObject Message;
	public Transform MessagePoint;
	public GameObject TheLock;
	public int counterLock;
	public AudioSource denySound;

	// Use this for initialization
	void Start () {
		counterLock = 0;
		if (PlayerPrefs.GetInt ("Lvl3") >= 1) {
			Destroy (TheLock);
		}
	}

	// Update is called once per frame
	void Update () {
		counterLock--;

	}

	void OnMouseDown(){
		if (PlayerPrefs.GetInt ("Lvl3") < 1) {
			if (counterLock <= 0) {
				denySound.Play ();
				Instantiate (Message, MessagePoint.position, MessagePoint.rotation);
				counterLock = 90;
				//PlayerPrefs.SetInt ("Lvl3", 1);
				//PlayerPrefs.Save();
			}
		} 
	}
}
