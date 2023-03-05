using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public float moveSpeed = 600f;
	float movement = 0f;
	public Button restart;
	public UIManager uim;

	/// Start is called on the frame when a script is enabled just before
	void Start()
	{
		restart.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		movement =  Input.GetAxisRaw("Horizontal");
	}

	private void FixedUpdate()
	{
		transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Time.timeScale = 0;
		restart.gameObject.SetActive(true);
		if(uim.time > PlayerPrefs.GetFloat("BestTime")){
			PlayerPrefs.SetFloat("BestTime", uim.time);
		}
	}

	public void restartGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}
}
