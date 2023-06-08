using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateHighScore : MonoBehaviour
{
	public TextMeshProUGUI highScores;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScores.text = "High Score: " + GameManager.highScore.ToString();
    }
}
