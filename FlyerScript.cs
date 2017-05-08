// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyerScript : MonoBehaviour {

    private Rigidbody thisRigid;
    private Rigidbody blaster;
    public int moveThrust;
    public int torqueThrust;
	public int boostThrust;

	public GameObject Tango;

    // Use this for initialization
    void Start () {
        thisRigid = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
		gameObject.SendMessage("VelocityReport", thisRigid.velocity);

		if (Input.GetKey(KeyCode.W))
        {
            thisRigid.AddForce(transform.forward * moveThrust); 
        }
        if (Input.GetKey(KeyCode.S))
        {
            thisRigid.AddForce(transform.forward * -moveThrust); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            thisRigid.AddForce(transform.right * moveThrust); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            thisRigid.AddForce(transform.right * -moveThrust); 
        }
        if (Input.GetKey(KeyCode.E))
        {
            thisRigid.AddForce(transform.up * moveThrust); 
        }
        if (Input.GetKey(KeyCode.Q)){
            thisRigid.AddForce(transform.up * -moveThrust); 
        }

        if (Input.GetKey(KeyCode.Keypad6)){
            thisRigid.AddTorque(transform.up * torqueThrust); 
        }
        if (Input.GetKey(KeyCode.Keypad4)){
            thisRigid.AddTorque(transform.up * -torqueThrust); 
        }
        if (Input.GetKey(KeyCode.Keypad5)){
            thisRigid.AddTorque(transform.right * torqueThrust); 
        }
        if (Input.GetKey(KeyCode.Keypad8)){
            thisRigid.AddTorque(transform.right * -torqueThrust); 
        }
        if (Input.GetKey(KeyCode.KeypadEnter) || Input.GetKey(KeyCode.Return)){
            thisRigid.angularVelocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.LeftShift)){
			thisRigid.velocity = thisRigid.velocity / 2;
			thisRigid.angularVelocity = thisRigid.angularVelocity / 2;
		}
		if (Input.GetKey(KeyCode.Tab)){
			thisRigid.AddForce(transform.forward * boostThrust);
		}
		if (Input.GetKey(KeyCode.Delete))
		{
			Cursor.lockState = CursorLockMode.None;
			UnityEngine.SceneManagement.SceneManager.LoadScene("menuScene");
		}
        /**
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject projectile = Instantiate(preProj) as GameObject;
            projectile.transform.position = blaster.transform.position;
            Rigidbody projRigBod = projectile.GetComponent<Rigidbody>();

            projRigBod.velocity = blaster.transform.TransformDirection(Vector3.forward * 40);
        }
        */
    }

	private void OnTriggerEnter(Collider col)
	{
		if (col.tag == "projectileTango")
		{
			gameObject.SendMessage("TangoScored", 1);
		}
	}
}

	
