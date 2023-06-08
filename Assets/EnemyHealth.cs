using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public int enemyHealth = 3;
	int timer = 1;
	public AudioClip otherClip;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "bullet")
		{
			enemyHealth --;
		}
	}
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		timer ++;
        if(enemyHealth <= 0)
		{
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			Destroy(this.gameObject);
			GameManager.score++;
		}
    }
}
