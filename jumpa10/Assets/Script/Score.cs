using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	static int ScoreP= 0;
	static Text ScoreText;

	void Start () { 
		ScoreText = GameObject.FindGameObjectWithTag ("ScoreText").GetComponent<Text> ();
		UpdateScore (ScoreP);
	}

	public static void UpdateScore(int nilai)
	{
		ScoreP += nilai;
		ScoreText.text = "" + ScoreP;
	}
}
