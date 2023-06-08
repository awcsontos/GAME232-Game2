using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletDamage : MonoBehaviour
{
	public GameObject player;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy(other.gameObject);
			Destroy(this.gameObject);
			GameManager.playerLives--;
			Instantiate(player, new Vector3(0, -3, 0), Quaternion.identity);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
