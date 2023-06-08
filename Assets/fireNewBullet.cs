using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireNewBullet : MonoBehaviour
{
	public AudioClip audio;
	public Transform newBullet;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Space))
		{
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			Instantiate(newBullet, transform.position, Quaternion.identity);
		}
    }
}
