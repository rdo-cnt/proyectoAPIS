using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour {

	public Text HP;

	// Use this for initialization
	void Start () {
		HP = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
