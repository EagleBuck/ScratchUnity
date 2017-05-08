// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

	public Text PlayerVelocity;
	private float PlayerVelocityCount;

	public Text PlayerPoints;
	public Text TangoPoints;
	private float PlayerPointCount;
	private float TangoPointCount;

	public int StartTime;

	private float Counter;

	public Text CountDown;
	public Image ResultsBackground;
	public Text Results1;
	public Text Results2;

	public Image HUDBlur;

	// Use this for initialization
	void Start () {
		PlayerPointCount = 0;
		TangoPointCount = 0;
		Counter = StartTime;
	}

	// Update is called once per frame
	void Update()
	{
		Counter -= Time.deltaTime;
		if (Counter < 0)
		{
			Cursor.lockState = CursorLockMode.None;
			CountDown.text = "Round Over";
			Time.timeScale = 0;
			ResultsBackground.transform.localScale = new Vector3(1, 1, 1);
			if(PlayerPointCount > TangoPointCount)
			{
				Results1.text = "Victory!";
			}
			else if(PlayerPointCount == TangoPointCount)
			{
				Results1.text = "Tie! That never happens";
			}
			else
			{
				Results1.text = "Defeat!";
			}
			Results2.text = (PlayerPointCount - TangoPointCount).ToString() + " Points";
		}
		else
		{
			CountDown.text = Counter.ToString("F1");

		}
	}

	void VelocityReport(Vector3 velocity)
	{
		PlayerVelocity.text = velocity.magnitude.ToString("F1");
	}
	void PlayerScored(int amount)
	{
		PlayerPointCount += amount;
		PlayerPoints.text = PlayerPointCount.ToString();
	}

	void TangoScored()
	{
		TangoPointCount += 1;
		TangoPoints.text = TangoPointCount.ToString();
	}
	void MaskHit()
	{
		HUDBlur.transform.localScale += new Vector3(2,2,2);
	}
}
