/// <summary>
/// Name:           ShopMenuScript.cs
/// Author:         Kane Adams
/// Date Created:   09/04/2020
/// Briefs:			Creates the functionality for the in-game Shop
/// </summary>

using UnityEngine;

public class ShopMenuScript : MonoBehaviour {
	// Appears when the player clicks the shop button
	public GameObject shopMenuUI;

	// Disappears when the layer clicks the shop button
	public GameObject mainGameButton;
	public GameObject pauseButton;
	public GameObject shopButton;

	/// <summary>
	/// When the player clicks the Shop button, 
	/// the shop menu opens and the main game buttons disappear
	/// </summary>
	public void OpenShop() {
		mainGameButton.SetActive(false);
		shopButton.SetActive(false);
		pauseButton.SetActive(false);

		shopMenuUI.SetActive(true);
	}

	/// <summary>
	/// When the return button is pressed,
	/// the shop menu is hidden and the main game buttons appears
	/// </summary>
	public void ReturnToGame() {
		shopMenuUI.SetActive(false);

		pauseButton.SetActive(true);
		shopButton.SetActive(true);
		mainGameButton.SetActive(true);
	}
}