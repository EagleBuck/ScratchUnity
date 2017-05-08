// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {

    public GameObject emitter;
    public GameObject projectile;
	public GameObject flyer;
    public float projectileForce;
	public int burnOutTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // https://pastebin.com/mgN2wuq7

        if (Input.GetKey(KeyCode.Space))
        {
            GameObject tempProjectileHandler;
            tempProjectileHandler = Instantiate(projectile, emitter.transform.position, emitter.transform.rotation) as GameObject;
            tempProjectileHandler.transform.Rotate(Vector3.left * 90);
            Rigidbody tempRigidBody;
            tempRigidBody = tempProjectileHandler.GetComponent<Rigidbody>();

			tempRigidBody.velocity = flyer.GetComponent<Rigidbody>().velocity;
            tempRigidBody.AddForce(transform.forward * projectileForce); // + flyer.GetComponent<Rigidbody>().velocity
			Destroy(tempProjectileHandler, burnOutTime);
        }

    }
}
