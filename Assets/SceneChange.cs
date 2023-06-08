using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
	public AudioClip audio;
	public Button yourButton;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}

	void TaskOnClick(){
		string nextScene = "gameScene";
		GameManager.playerLives = 3;
		GameManager.score = 0;
		SceneChanger(nextScene);
	}

    // Update is called once per frame
    void Update()
    {

    }
	
	void SceneChanger(string nextScene)
	{
		SceneManager.LoadScene(nextScene);
	}
}
