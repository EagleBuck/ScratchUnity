// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyerHeadScript : MonoBehaviour {

	private Rigidbody thisRigid;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider col)
	{
		if (col.tag == "projectileTango")
		{
			gameObject.SendMessage("TangoScored", 3);
			gameObject.SendMessage("MaskHit");
		}
	}
}
