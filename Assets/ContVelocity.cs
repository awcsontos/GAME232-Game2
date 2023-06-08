using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContVelocity : MonoBehaviour
{
	public float speedY = 5.0f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var vel = GetComponent<Rigidbody2D>().velocity;
		vel.y = speedY;
		GetComponent<Rigidbody2D>().velocity = vel;
    }
}
