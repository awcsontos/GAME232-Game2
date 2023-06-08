using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnNew : MonoBehaviour
{
	public Transform enemy1;
	
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void spawnEnemy()
	{
		float randType = Random.Range(-9.0f, 9.0f);
		
		Instantiate(enemy1, new Vector3(randType, 5.0f, 0.0f), Quaternion.AngleAxis(180, Vector3.right));
	}
}
