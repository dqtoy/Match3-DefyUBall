using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {


	private Text CurrentScore;


	// Use this for initialization
	void Start ()
	{
		
		CurrentScore = GetComponent<Text>();
		
	}
	

	// Update is called once per frame
	void Update () 
	{
		CurrentScore.text = GameManagerArk.Instance.GetScore().ToString();
	}

	

}
