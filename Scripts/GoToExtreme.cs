// Justin DiPietro
// 16208316
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToExtreme : MonoBehaviour {

	public void loadExtreme()
	{
		Time.timeScale = 1;
		UnityEngine.SceneManagement.SceneManager.LoadScene("Battle3Scene");
	}
}
