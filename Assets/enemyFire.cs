using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour
{
	public AudioClip audio;
	public Transform enemyBullet1;
	
	int time = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time++;
		
		if(time == 1000)
		{
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			Instantiate(enemyBullet1, transform.position, Quaternion.identity);
			time = 0;
		}
    }
}
