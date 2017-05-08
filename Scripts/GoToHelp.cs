// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToHelp : MonoBehaviour {

	public void loadHelp()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("HelpScene");
	}
}
