/// <summary>
/// Name:           BuffsScript.cs
/// Author:         Kane Adams
/// Date Created:   14/04/2020
/// Brief:			Contains the code for the buyable buffs
/// </summary>

using UnityEngine;
using UnityEngine.UI;

public class BuffsScript : MonoBehaviour {
	// Buff 1 variables
	float buff1Cost;
	float buff1Income;
	int buff1Lvl;
	public Button buff1Button;
	public Text buff1IncomeText;
	public Text buff1CostText;
	public Text buff1LvlText;


	// Buff 2 variables
	float buff2Cost;
	float buff2Income;
	int buff2Lvl;
	public Button buff2Button;
	public Text buff2IncomeText;
	public Text buff2CostText;
	public Text buff2LvlText;


	// Buff 3 variables
	float buff3Cost;
	float buff3Income;
	int buff3Lvl;
	public Button buff3Button;
	public Text buff3IncomeText;
	public Text buff3CostText;
	public Text buff3LvlText;


	// Buff 4 variables
	float buff4Cost;
	float buff4Income;
	int buff4Lvl;
	public Button buff4Button;
	public Text buff4IncomeText;
	public Text buff4CostText;
	public Text buff4LvlText;

	// Buff 5 variables
	float buff5Cost;
	float buff5Income;
	int buff5Lvl;
	public Button buff5Button;
	public Text buff5IncomeText;
	public Text buff5CostText;
	public Text buff5LvlText;

	int maxBuffLvl = 100;

	// Gets access to the main game script's buffs
	GameObject gameCanvas;
	MainGameScript mainScript;

	// Start is called before the first frame update
	void Start() {
		gameCanvas = GameObject.Find("Canvas");
		mainScript = gameCanvas.GetComponent<MainGameScript>();

		buff1Cost = 10;
		SetToDefault(buff1CostText, buff1LvlText, buff1Cost, ref buff1Income, ref buff1Lvl);

		buff2Cost = 50;
		SetToDefault(buff2CostText, buff2LvlText, buff2Cost, ref buff2Income, ref buff2Lvl);

		buff3Cost = 250;
		SetToDefault(buff3CostText, buff3LvlText, buff3Cost, ref buff3Income, ref buff3Lvl);

		buff4Cost = 1250;
		SetToDefault(buff4CostText, buff4LvlText, buff4Cost, ref buff4Income, ref buff4Lvl);

		buff5Cost = 6250;
		SetToDefault(buff5CostText, buff5LvlText, buff5Cost, ref buff5Income, ref buff5Lvl);
	}

	// Update is called once per frame
	void Update() {
		IsBuffAvailable(buff1Button, buff1Lvl, buff1Cost);
		IsBuffAvailable(buff2Button, buff2Lvl, buff2Cost);
		IsBuffAvailable(buff3Button, buff3Lvl, buff3Cost);
		IsBuffAvailable(buff4Button, buff4Lvl, buff4Cost);
		IsBuffAvailable(buff5Button, buff5Lvl, buff5Cost);

		ChangeOverallIncome();
	}

	/// <summary>
	/// Increases income per second by 0.1 * buff's level
	/// </summary>
	public void Buff1() {
		buff1Lvl++;
		mainScript.balance -= buff1Cost;
		buff1Cost *= 1.30f;

		buff1Income += 0.10f * buff1Lvl;

		buff1IncomeText.text = "Boost: " + buff1Income.ToString("c2") + " per sec";

		buff1LvlText.text = "Level: " + buff1Lvl;
		buff1CostText.text = "Cost: " + buff1Cost.ToString("c2");
	}

	/// <summary>
	/// Increases income per second by 1 * buff's level
	/// </summary>
	public void Buff2() {
		//buff2Lvl++;
		//mainScript.balance -= buff2Cost;
		//buff2Cost *= 1.30f;

		//buff2Income = 1.00f * buff2Lvl;

		//buff2LvlText.text = "Level: " + buff2Lvl;
		//buff2CostText.text = "Cost: " + buff2Cost.ToString("c2");

		//mainScript.clickMultiplier = 1 + buff2Income;
		//buff2IncomeText.text = "Boost: " + buff2Income.ToString("c2") + " per click";
		buff2Lvl++;
		mainScript.balance -= buff2Cost;
		buff2Cost *= 1.30f;

		buff2Income += 1.00f * buff2Lvl;

		buff2IncomeText.text = "Boost: " + buff2Income.ToString("c2") + " per sec";

		buff2LvlText.text = "Level: " + buff2Lvl;
		buff2CostText.text = "Cost: " + buff2Cost.ToString("c2");
	}

	/// <summary>
	/// Increases income per second by 10 * buff's level
	/// </summary>
	public void Buff3() {
		buff3Lvl++;
		mainScript.balance -= buff3Cost;
		buff3Cost *= 1.25f;

		buff3Income += 10.00f * buff3Lvl;

		buff3IncomeText.text = "Boost: " + buff3Income.ToString("c2") + " per sec";

		buff3LvlText.text = "Level: " + buff3Lvl;
		buff3CostText.text = "Cost: " + buff3Cost.ToString("c2");
	}

	/// <summary>
	/// Increases income per second by 100 * buff's level
	/// </summary>
	public void Buff4() {
		//buff4Lvl++;
		//mainScript.balance -= buff4Cost;
		//buff4Cost *= 1.20f;

		//buff4Income = 100.0f * buff4Lvl;

		//buff4LvlText.text = "Level: " + buff4Lvl;
		//buff4CostText.text = "Cost: " + buff4Cost.ToString("c2");

		//mainScript.clickMultiplier = 1 + buff4Income;
		//buff4IncomeText.text = "Boost: " + buff4Income.ToString("c2") + " per click";
		buff4Lvl++;
		mainScript.balance -= buff4Cost;
		buff4Cost *= 1.25f;

		buff4Income += 100.00f * buff4Lvl;

		buff4IncomeText.text = "Boost: " + buff4Income.ToString("c2") + " per sec";

		buff4LvlText.text = "Level: " + buff4Lvl;
		buff4CostText.text = "Cost: " + buff4Cost.ToString("c2");
	}

	/// <summary>
	/// Increases income per second by 1000 * buff's level
	/// </summary>
	public void Buff5() {
		buff5Lvl++;
		mainScript.balance -= buff5Cost;
		buff5Cost *= 1.20f;

		buff5Income += 1000.0f * buff5Lvl;

		buff5IncomeText.text = "Boost: " + buff5Income.ToString("c2") + " per sec";

		buff5LvlText.text = "Level: " + buff5Lvl;
		buff5CostText.text = "Cost: " + buff5Cost.ToString("c2");
	}

	/// <summary>
	/// Checks which buffs can be bought.
	/// If the buff is maxed out or costs too much, the button is disabled
	/// </summary>
	void IsBuffAvailable(Button a_buffButton, int a_buffLvl, float a_buffCost) {
		if (a_buffLvl >= maxBuffLvl || a_buffCost > mainScript.balance) {
			a_buffButton.interactable = false;
		} else {
			a_buffButton.interactable = true;
		}
	}

	/// <summary>
	/// Changes the income the player gets per second
	/// </summary>
	void ChangeOverallIncome() {
		mainScript.income = buff1Income + buff2Income + buff3Income + buff4Income + buff5Income;
	}

	/// <summary>
	/// Sets all the buff's variables to default
	/// </summary>
	/// <param name="a_buffCostText">Text for the specific buff's cost</param>
	/// <param name="a_buffLvlText">Text for the specific buff's level</param>
	/// <param name="a_buffCost">Cost for the specific buff</param>
	/// <param name="a_buffIncome">Income for the specific buff</param>
	/// <param name="a_buffLvl">Level for the specific buff</param>
	void SetToDefault(Text a_buffCostText, Text a_buffLvlText, float a_buffCost, ref float a_buffIncome, ref int a_buffLvl) {
		a_buffLvl = 0;
		a_buffIncome = 0.00f;
		a_buffCostText.text = "";
		a_buffLvlText.text = "";
		a_buffCostText.text = "Cost: " + a_buffCost.ToString("c2");
	}
}