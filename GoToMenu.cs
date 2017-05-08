// Justin DiPietro
// 16208316

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToMenu : MonoBehaviour {

	public void loadMenu()
	{
		Cursor.lockState = CursorLockMode.None;
		Time.timeScale = 1;
		UnityEngine.SceneManagement.SceneManager.LoadScene("menuScene");
		//Application.SceneManager.LoadScene("menuScene");
	}
}
