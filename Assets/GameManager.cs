using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static int score = 0;
	public static int playerLives = 3;
	public static int highScore = 0;
	public GameObject player;
	public AudioClip otherClip;
	
	
	void OnGUI()
	{
		GUI.Label (new Rect (20, 20, 80, 40), "Score: " + score);
		GUI.Label (new Rect (20, 50, 80, 40), "High Score: " + highScore);
		GUI.Label (new Rect (20, 32, 80, 40), "Lives: " + playerLives);
	}
	
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, new Vector3(0, -3, 0), Quaternion.identity);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(score > highScore)
		{
			highScore = score;
		}
    }
}
