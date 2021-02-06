/// <summary>
/// Name:           MainGameScript.cs
/// Author:         Kane Adams
/// Date Created:   13/03/2020
/// Briefs:			Increases player's balance, either by the player clicking or every second
/// </summary>

using UnityEngine;
using UnityEngine.UI;

public class MainGameScript : MonoBehaviour {
	public float balance;           // Player's current total money
									//public float clickMultiplier;   // As the player buys upgrades, multiplier will increase
	public float income;            // Money earned per second
	float time = 1.0f;              // Used to change balance each second

	// Variables to change the text GameObjects
	public Text balanceText;
	public Text incomeText;
	public Text shopBalanceText;
	public Text shopIncomeText;

	// Start is called before the first frame update
	void Start() {
		balance = 0.00f;            // Balance starts empty
									//clickMultiplier = 1.00f;    // Default, 1 click = £1
		income = 0.00f;             // Default, No income

		balance = PlayerPrefs.GetFloat("balance");
		income = PlayerPrefs.GetFloat("income");
		//clickMultiplier = PlayerPrefs.GetFloat("clickMultiplier");
	}

	// Update is called once per frame
	void Update() {
		// Changes the texts to show new balance and income (formats float to currency (2dp)
		balanceText.text = "Balance: " + balance.ToString("c2");
		shopBalanceText.text = balanceText.text;

		incomeText.text = "Income (per sec): " + income.ToString("c2");
		shopIncomeText.text = incomeText.text;

		// When time reaches zero, increase balance by income and reset, otherwise countdown
		if (time <= 0) {
			balance += income;
			time = 1.0f;
		} else {
			time -= Time.deltaTime;
		}
	}

	/// <summary>
	/// When the main button is clicked, the total money the player has increases.
	/// Amount will depend on what/amount of upgrades player has.
	/// </summary>
	public void OnMoneyButtonClick() {
		balance += 1;// * clickMultiplier;
	}
}