// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToHard : MonoBehaviour {

	public void loadHard()
	{
		Time.timeScale = 1;
		UnityEngine.SceneManagement.SceneManager.LoadScene("Battle2Scene");
	}
}
