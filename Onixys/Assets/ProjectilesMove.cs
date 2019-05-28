using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilesMove : MonoBehaviour {

    public float speed;
    public float fireRate;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * (speed * Time.deltaTime);
	}

    void OnCollisionEnter(Collision co)
    {
        speed = 0;
        Destroy(gameObject);
    }
}
