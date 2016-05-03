using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Level3Manager : MonoBehaviour {


	public labelManager3[] labels;
	public int playerHealth;
	public int enemyHealth;

	public pregunta1Manager preguntaText;
	public pregunta2Manager preguntaImage;
	public HealthManager HP;
	public EnemyHealthManager enemyHP;

	int conta = 0;
	public int randomNum;
	public int randomNumPregunta;
	public int randomNumQuestions;

	public string[] preguntas = new string[83] {"Kripton", "Rubidio", "Estroncio","Ytrio", "Circonio", "Niobio","Molibdeno", "Tecnecio", "Rutenio","Rodio", "Paladio", "Plata","Cadmio", "Indio", "Estaño","Antimonio", "Teluro", "Yodo","Xenon", "Cesio", "Bario","Lantano", "Cerio", "Praseodimio","Neodimio", "Prometio", "Samario","Europio", "Gadolinio", "Terbio","Disprosio", "Holmio", "Erbio","Tulio", "Yterbio", "Lutecio", "Hafnio", "Tantalo","Wolframio", "Renio", "Osmio","Iridio", "Platino", "Oro","Mercurio", "Talio", "Plomo","Bismuto", "Polonio", "Astato","Radon", "Francio", "Radio","Actinio", "Torio", "Protactinio","Uranio", "Neptunio", "Plutonio","Americio", "Curio", "Berkelio","Californio", "Einstenio", "Fermio","Mendelevio", "Nobelio", "Lawrencio","Rutherfordio", "Dubnio", "Seaborgio", "Bohrio", "Hassio","Meitnerio", "Darmstadtio", "Roentgenio","Copernicio", "Ununtrio", "Flerovio","Ununpentio", "Livermorio", "Ununseptio","Ununoctio"};
	public Sprite[] preguntasSprites;

	public string[] respuestasCorrectas = new string[83] {"Kr", "Rb", "Sr","Y", "Zr", "Nb","Mo", "Tc", "Ru","Rh", "Pd", "Ag","Cd", "In", "Sn","Sb", "T", "I","Xe", "Cs", "Ba","La", "Ce", "Pr","Nd", "Pm", "Sm","Eu", "Gd", "Tb","Dy", "Ho", "Er","Tm", "Yb", "Lu", "Hf", "Ta","W", "Re", "Os","Ir", "Pt", "Au","Hg", "Tl", "Pb","Bi", "Po", "At","Rn", "Fr", "Ra","Ac", "Th", "Pa","U", "Np", "Pu","Am", "Cm", "Bk","Cf", "Es", "Fm","Md", "No", "Lr","Rf", "Db", "Sg", "Bh", "Hs","Mt", "Ds", "Rg","Cn", "Uut", "Fl","Uup", "Lv", "Uus","Uuo"};
	public string[] respuestasCorrectas2 = new string[28] {"Metano", "Etano", "Propano","Butano", "Pentano", "Hexano","Heptano", "Octano", "Nonano","Decano", "Eteno", "Propeno","Buteno", "Penteno", "Hexeno","Hepteno", "Octeno", "Noneno","Deceno", "Etino", "Propino","Butino", "Pentino", "Hexino","Heptino", "Octino", "Nonino","Decino"};


	public string[] respuestaIncorrectas1 = new string[83] {"K", "R", "Est","Ytrio", "Ci", "N","M", "Te", "R","Ro", "Pa", "Pl","Ca", "Id", "Es","An", "Te", "Yo","Xn", "Ce", "Br","L", "Cr", "Pa","Ne", "Pr", "Sa","Er", "Ga", "Te","Di", "Hl", "Eb","Tu", "Yt", "Lt", "Ha", "Tn","Wo", "Rn", "Om","Id", "Pl", "Or","Me", "Ta", "Pl","Bs", "Pl", "As","Ra", "Fa", "Rd","At", "To", "Pr","Ur", "Ne", "Pl","Ae", "Cu", "Be","Ca", "Ei", "Fe","Me", "Nb", "La","Ru", "Du", "Se", "Bo", "Ha","Me", "Da", "Ro","Co", "Ut", "Fe","Up", "Li", "Us","Uua"};
	public string[] respuestaIncorrectas2 = new string[83] {"Kri", "Ru", "Es","Ytr", "Cr", "Ni","Mol", "T", "Rut","Rd", "P", "A","Cm", "Io", "Et","At", "Tl", "Io","X", "Ci", "B","Ln", "C", "Ps","No", "Po", "Sr","Ep", "Gl", "Tr","Ds", "Hm", "Ei","Tl", "Yo", "Le", "Hn", "Tl","Wl", "Ro", "Oi","Io", "Pa", "Ao","Mr", "Ti", "Po","Bm", "Pn", "Aa","Rd", "Fn", "Ri","Ai", "Tr", "Po","Un", "Nt", "Pt","Ar", "Cr", "Br","Cl", "En", "Fr","Ml", "Nl", "Lw","Rt", "Dn", "Sb", "Br", "Hi","Mi", "Dt", "Re","Cp", "Ur", "Fr","Ue", "Le", "Un","Uou"};
	public string[] respuestaIncorrectas3 = new string[83] {"Ki", "Rub", "Et","Yr", "Cir", "Nio","Ml", "Tec", "Rt","Ri", "Pl", "P","C", "I", "St","Am", "Tr", "Y","Xo", "C", "Bo","Lt", "Co", "P","Nm", "Pt", "So","Eo", "Go", "To","Dp", "Hi", "Eo","To", "Yr", "Lc", "Ho", "To","Wf", "Ri", "O","Iri", "Pn", "Ar","Ho", "To", "Pm","Bt", "Pi", "Ao","Ro", "Fo", "Ro","An", "Ti", "Pt","Uo", "No", "Po","Ac", "Co", "Bl","Cn", "Et", "Fo","Mv", "Ne", "Ln","Rd", "Do", "So", "Bi", "Ho","Mn", "Do", "Rn","Ci", "Uo", "Fv","Ut", "Lm", "Up","Uut"};
	public string[] respuestaIncorrectas32 = new string[28] {"Butano", "Pentano", "Hexano","Heptano", "Octano", "Nonano","Decano", "Eteno", "Propeno","Buteno", "Penteno", "Hexeno","Hepteno", "Octeno", "Noneno","Deceno", "Etino", "Propino","Butino", "Pentino", "Hexino","Heptino", "Octino", "Nonino","Decino", "Metano", "Etano","Propano"};
	public string[] respuestaIncorrectas22 = new string[28] {"Propano","Butano", "Pentano", "Hexano","Heptano", "Octano", "Nonano","Decano", "Eteno", "Propeno","Buteno", "Penteno", "Hexeno","Hepteno", "Octeno", "Noneno","Deceno", "Etino", "Propino","Butino", "Pentino", "Hexino","Heptino", "Octino", "Nonino","Decino", "Metano", "Etano"};
	public string[] respuestaIncorrectas12 = new string[28] {"Eteno", "Propeno","Buteno", "Penteno", "Hexeno","Hepteno", "Octeno", "Noneno","Deceno", "Etano", "Propano","Butano", "Pentano", "Hexano","Heptano", "Octano", "Nonano","Decano", "Etino", "Propino","Butino", "Pentino", "Hexino","Heptino", "Octino", "Nonino","Decino", "Metano"};

	public AudioSource wrongSound;
	public AudioSource rightSound;


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
			SceneManager.LoadScene ("Nivel3Victory");
			PlayerPrefs.SetInt ("Lvl3", 1);
		}
	}

	public void Repartir(){
		randomNumQuestions = Random.Range (0, 2);

		if (randomNumQuestions == 0) {
			randomNum = Random.Range (0, 4);
			randomNumPregunta = Random.Range (0, 83);
			preguntaText.pregunta.text = preguntas [randomNumPregunta];


			labels[randomNum].myID = randomNumPregunta;
			labels[randomNum].myText.text = respuestasCorrectas[randomNumPregunta];
			preguntaImage.pregunta.sprite = null;

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


		} else {
			randomNum = Random.Range (0, 4);
			randomNumPregunta = Random.Range (0, 28);
			preguntaImage.pregunta.sprite = preguntasSprites [randomNumPregunta];
			preguntaText.pregunta.text = "";


			labels[randomNum].myID = randomNumPregunta;
			labels[randomNum].myText.text = respuestasCorrectas2[randomNumPregunta];

			for (int i = 0, iRandom = Random.Range(0,4) ; i < 4; i++, iRandom++) {
				if (iRandom % 4 != randomNum) {
					switch (i) {
					case 0:
						labels [iRandom % 4].myID = -1;
						labels [iRandom % 4].myText.text = respuestaIncorrectas12 [randomNumPregunta];
						break;
					case 1:
						labels [iRandom % 4].myID = -1;
						labels [iRandom % 4].myText.text = respuestaIncorrectas22 [randomNumPregunta];
						break;
					case 2:
						labels [iRandom % 4].myID = -1;
						labels [iRandom % 4].myText.text = respuestaIncorrectas32 [randomNumPregunta];
						break;
					}
				} else {
					i--;
				}
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
