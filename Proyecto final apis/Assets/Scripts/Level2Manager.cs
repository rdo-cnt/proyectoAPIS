using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level2Manager : MonoBehaviour {

	public labelManager2[] labels;
	public int playerHealth;
	public int enemyHealth;

	public pregunta2Manager preguntaImage;
	public HealthManager HP;
	public EnemyHealthManager enemyHP;

	int conta = 0;
	public int randomNum;
	public int randomNumPregunta;
	public string[] respuestasCorrectas = new string[28] {"Metano", "Etano", "Propano","Butano", "Pentano", "Hexano","Heptano", "Octano", "Nonano","Decano", "Eteno", "Propeno","Buteno", "Penteno", "Hexeno","Hepteno", "Octeno", "Noneno","Deceno", "Etino", "Propino","Butino", "Pentino", "Hexino","Heptino", "Octino", "Nonino","Decino"};
	public Sprite[] preguntas;
	public string[] respuestaIncorrectas3 = new string[28] {"Butano", "Pentano", "Hexano","Heptano", "Octano", "Nonano","Decano", "Eteno", "Propeno","Buteno", "Penteno", "Hexeno","Hepteno", "Octeno", "Noneno","Deceno", "Etino", "Propino","Butino", "Pentino", "Hexino","Heptino", "Octino", "Nonino","Decino", "Metano", "Etano","Propano"};
	public string[] respuestaIncorrectas2 = new string[28] {"Propano","Butano", "Pentano", "Hexano","Heptano", "Octano", "Nonano","Decano", "Eteno", "Propeno","Buteno", "Penteno", "Hexeno","Hepteno", "Octeno", "Noneno","Deceno", "Etino", "Propino","Butino", "Pentino", "Hexino","Heptino", "Octino", "Nonino","Decino", "Metano", "Etano"};
	public string[] respuestaIncorrectas1 = new string[28] {"Eteno", "Propeno","Buteno", "Penteno", "Hexeno","Hepteno", "Octeno", "Noneno","Deceno", "Etano", "Propano","Butano", "Pentano", "Hexano","Heptano", "Octano", "Nonano","Decano", "Etino", "Propino","Butino", "Pentino", "Hexino","Heptino", "Octino", "Nonino","Decino", "Metano"};


	void Start () {
		

	}

	// Update is called once per frame
	void Update () {
		if (conta == 0) {
			Repartir ();
			conta++;
		}	

		HP.HP.text = playerHealth.ToString();
		enemyHP.HP.text = enemyHealth.ToString();

		//primero checar vida
		if (playerHealth == 0) {
			SceneManager.LoadScene ("GameOver");
		}

		if (enemyHealth == 0) {
			SceneManager.LoadScene ("Nivel2Victory");
			PlayerPrefs.SetInt ("Lvl3", 1);
		}
	}

	public void Repartir(){
		randomNum = Random.Range (0, 4);
		randomNumPregunta = Random.Range (0, 28);
		preguntaImage.pregunta.sprite = preguntas [randomNumPregunta];


		labels[randomNum].myID = randomNumPregunta;
		labels[randomNum].myText.text = respuestasCorrectas[randomNumPregunta];

		for (int i = 0, iRandom = Random.Range(0,4) ; i < 4; i++, iRandom++) {
			if (iRandom % 4 != randomNum) {
				switch (i) {
				case 0:
					labels [iRandom % 4].myID = -1;
					labels [iRandom % 4].myText.text = respuestaIncorrectas1 [randomNumPregunta];
					break;
				case 1:
					labels [iRandom % 4].myID = -1;
					labels [iRandom % 4].myText.text = respuestaIncorrectas2 [randomNumPregunta];
					break;
				case 2:
					labels [iRandom % 4].myID = -1;
					labels [iRandom % 4].myText.text = respuestaIncorrectas3 [randomNumPregunta];
					break;
				}
			} else {
				i--;
			}
		}

	}

	public void checkCorrect(int id){
		if (randomNumPregunta == id) {
			enemyHealth--;
			Repartir ();
		} else {
			playerHealth--;
		}
	}

}
