using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public Text timeText;
	public Text bestTimeText;
	public float time;
	// Use this for initialization
	void Start () {
		timeText = GameObject.Find("Time").GetComponent<Text>();
		bestTimeText = GameObject.Find("BestTime").GetComponent<Text>();
		bestTimeText.text = "Best time: " + PlayerPrefs.GetFloat("BestTime").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		timeText.text = "Time: " + time;
	}
}
