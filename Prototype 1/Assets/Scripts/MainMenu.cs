using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

	public void PlayGame()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
		}
	public void QuitGame ()
	{
		Debug.Log("QUIT!");
		Application.Quit();
	}
	public void PlayAgain()
	{
		 SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		Time.timeScale = 1f;
	}
	public void BackToMainMenu()
		{
		SceneManager.LoadScene("MainMenu");
		Time.timeScale = 1f;
		}
	//SceneManager.LoadScene("OtherSceneName", LoadSceneMode.Additive);
	//This Loads a scene on top of another scene
}
