using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level1Manager : MonoBehaviour {

	public labelManager[] labels;
	public int playerHealth;
	public int enemyHealth;

	public pregunta1Manager preguntaText;
	public HealthManager HP;
	public EnemyHealthManager enemyHP;

	public AudioSource wrongSound;
	public AudioSource rightSound;

	int conta = 0;
	public int randomNum;
	public int randomNumQuestions;
	public int randomNumPregunta;
	public string[] respuestasCorrectas = new string[35] {"H", "He", "Li","Be", "B", "C","N", "O", "F","Ne", "Na", "Mg","Al", "Si", "P","S", "Cl", "Ar","K", "Ca", "Sc","Ti", "V", "Cr","Mn", "Fe", "Co","Ni", "Cu", "Zn","Ga", "Ge", "As","Se", "Br"};

	public string[] preguntas = new string[35] {"Hidrogeno", "Helio", "Litio","Berilio", "Boro", "Carbono","Nitrogeno", "Oxigeno", "Fluor","Neon", "Sodio", "Magnesio","Aluminio", "Silicio", "Fosforo","Azufre", "Cloro", "Argon","Potasio", "Calcio", "Escandio","Titanio", "Vanadio", "Cromo","Manganeso", "Hierro", "Cobalto","Niquel", "Cobre", "Zinc","Galio", "Germanio", "Arsenico","Selenio", "Bromo"};

	public string[] respuestaIncorrectas1 = new string[35] {"Hi", "H", "L","B", "Be", "Ca","Ni", "Ox", "Fl","N", "S", "Ma","A", "S", "F","A", "C", "Arg","Po", "Cal", "Es","T", "Va", "C","Man", "Hi", "C","N", "C", "Zi","G", "G", "Ar","S", "Bro"};
	public string[] respuestaIncorrectas2 = new string[35] {"Hid", "Hel", "Lit","Ber", "Bor", "Car","Nit", "Oxi", "Flu","Neo", "Sod", "Mag","Alu", "Sil", "Fos","Asu", "Clo", "A","Pot", "C", "Esc","Tit", "Van", "Cro","Ma", "Hie", "Cob","Niq", "Cob", "Zin","Gal", "Ger", "Ars","Sel", "B"};
	public string[] respuestaIncorrectas3 = new string[35] {"Hd", "Hl", "Lt","Br", "Br", "Cr","Nt", "Oi", "Fu","No", "Sd", "Mgn","Au", "Sl", "Ps","Au", "Co", "Ag","Ka", "Cl", "Sca","Tt", "Vn", "Co","Mg", "He", "Cb","Nq", "Cb", "Cn","Gl", "Gr", "A","Sl", "Bo"};

	void Start () {
		enemyHealth =  (int)(enemyHealth * 1.0f * PlayerPrefs.GetFloat ("Multi"));


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
			SceneManager.LoadScene ("Nivel1Victory");
			PlayerPrefs.SetInt ("Lvl2", 1);
		}
	}

	public void Repartir(){
		randomNum = Random.Range (0, 4);
		randomNumQuestions = Random.Range (0, 2);
		randomNumPregunta = Random.Range (0, 35);
		preguntaText.pregunta.text = preguntas [randomNumPregunta];


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
			rightSound.Play ();
			wrongSound.Stop();
		} else {
			playerHealth--;
			wrongSound.Stop();
			wrongSound.Play ();
		}
	}

}
