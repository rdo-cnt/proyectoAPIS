using UnityEngine;
using System.Collections;

public class Level1Manager : MonoBehaviour {

	public GameObject[] labels;
	public int playerHealth;
	public int enemyHealth;
	public string[] preguntas;
	public string[] respuestas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Repartir(){
		int randomNum = Random.Range (0, 3);
		int randomNumPregunta = Random.Range (0, 34);
	}

}
