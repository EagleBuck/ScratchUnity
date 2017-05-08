// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour {

	public void doExitGame()
	{
		Debug.LogError("quit");
		Application.Quit();
	}
}
