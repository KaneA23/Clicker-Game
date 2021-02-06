/// <summary>
/// Name:           PauseMenuScript.cs
/// Author:         Kane Adams
/// Date Created:   08/04/2020
/// Briefs:			Creates the functionality for a pause menu
/// </summary>

using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {
	// Appears when the game is paused
	public GameObject pauseMenuUI;

	// Disappears when the game is paused
	public GameObject mainGameButton;
	public GameObject pauseButton;
	public GameObject shopButton;

	public GameObject restartHint;  // Restart 'Are you sure?' message

	/// <summary>
	/// When the player clicks the pause button, 
	/// the pause menu appears and the unclickable buttons are hidden
	/// </summary>
	public void PauseGame() {
		mainGameButton.SetActive(false);
		shopButton.SetActive(false);
		pauseButton.SetActive(false);

		pauseMenuUI.SetActive(true);
	}

	/// <summary>
	/// When the resume button is pressed,
	/// the pause menu is hidden and the main game buttons appears
	/// </summary>
	public void ResumeGame() {
		pauseMenuUI.SetActive(false);

		pauseButton.SetActive(true);
		shopButton.SetActive(true);
		mainGameButton.SetActive(true);
	}

	/// <summary>
	/// When the restart button is clicked, a reset hint pops up to confirm
	/// </summary>
	public void RestartGame() {
		restartHint.SetActive(true);
	}

	/// <summary>
	/// When the stats button is clicked,
	/// the stats screen should appear for the player to view this (and previous) games
	/// </summary>
	public void StatsScreen() {
		Debug.Log("Looking at stats");
	}

	/// <summary>
	/// If the player clicks to confirm reset, Game is reset
	/// </summary>
	public void OnConfirmRestart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	/// <summary>
	/// If the player clicks to deny reset, the reset hint disappears
	/// </summary>
	public void OnDenyRestart() {
		restartHint.SetActive(false);
	}
}