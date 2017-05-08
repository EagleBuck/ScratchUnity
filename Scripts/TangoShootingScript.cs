// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangoShootingScript : MonoBehaviour {

    public GameObject emitter;
	public GameObject Tango;
    public GameObject projectile;
    public float projectileForce;
	public int burnOutTime;

	int count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // https://pastebin.com/mgN2wuq7

        if (count > 0 && count < 25)
        {
			Shoot();
        }
		if (count < 40)
		{
			count++;
		}
		else
		{
			count = 0;
		}

    }

	void Shoot()
	{
		GameObject tempProjectileHandler;
		tempProjectileHandler = Instantiate(projectile, emitter.transform.position, emitter.transform.rotation) as GameObject;
		tempProjectileHandler.transform.Rotate(Vector3.left * 90);
		Rigidbody tempRigidBody;
		tempRigidBody = tempProjectileHandler.GetComponent<Rigidbody>();

		tempRigidBody.velocity = Tango.GetComponent<Rigidbody>().velocity;
		tempRigidBody.AddForce(transform.forward * projectileForce);
		Destroy(tempProjectileHandler, burnOutTime);
	}
}
