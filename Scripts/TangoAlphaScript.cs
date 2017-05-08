// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangoAlphaScript : MonoBehaviour
{


	//int countDown = 120;
	private Rigidbody thisRigid;
	private Rigidbody blaster;
	private Rigidbody targetRigid;

	public string plan;
	public GameObject target;
	public int moveThrust;
	public int torqueThrust;

	// Use this for initialization
	void Start()
	{
		thisRigid = GetComponent<Rigidbody>();
		targetRigid = target.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		if (plan == "chase")
		{
			Chase();
		}
		else if (plan == "snipe")
		{
			Snipe();
		}
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.tag == "projectile")
		{
			target.SendMessage("PlayerScored", 1);
		}
	}

	void Snipe()
	{
		//Vector3 targetHeading = targetRigid.position - thisRigid.position;      // This stuff for getting target location
		//var targetDistance = targetHeading.magnitude;						// ^^^
		//var targetDirection = targetHeading / targetDistance;               // ^^^

		Transform targetTransform = targetRigid.transform;
		turnTo(1, targetTransform);

	}

	void Chase()
	{
		Transform targetTransform = targetRigid.transform;
		turnTo(1, targetTransform);
		moveForward();
	}

	void turnTo(float speed, Transform target)
	{
		var lookPos = target.position - transform.position;
		var rotation = Quaternion.LookRotation(lookPos);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * torqueThrust);
		// float step = torqueThrust * Time.deltaTime;
		//transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, step);
	}

	void moveForward()
	{
		thisRigid.AddForce(transform.forward * moveThrust);
	}
	void moveBackward()
	{
		thisRigid.AddForce(transform.forward * -moveThrust);
	}
	void moveRight()
	{
		thisRigid.AddForce(transform.right * moveThrust);
	}
	void moveLeft()
	{
		thisRigid.AddForce(transform.right * -moveThrust);
	}
	void turnUp()
	{
		thisRigid.AddTorque(transform.up * torqueThrust);
	}
	void turnDown()
	{
		thisRigid.AddTorque(transform.up * -torqueThrust);
	}
	void turnRight()
	{
		thisRigid.AddTorque(transform.right * torqueThrust);
	}
	void turnLeft()
	{
		thisRigid.AddTorque(transform.right * torqueThrust);
	}
}
