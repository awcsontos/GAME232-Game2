using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public float speed = 5;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void FixedUpdate()
	{
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
		
		Vector2 dir = new Vector2(h,v);
		GetComponent<Rigidbody2D>().velocity  = dir.normalized * speed;
		
		GetComponent<Animator>().SetBool("Flying", (v > 0));
	}
}
