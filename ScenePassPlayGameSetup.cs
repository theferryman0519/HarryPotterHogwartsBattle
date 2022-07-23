using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ScenePassPlayGameSetup : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	int AllyCardAmountGame0;
	int ItemCardAmountGame0;
	int SpellCardAmountGame0;
	int HogwartsCardAmountGame0;

	int AllyCardAmountGame1;
	int ItemCardAmountGame1;
	int SpellCardAmountGame1;
	int HogwartsCardAmountGame1;

	int AllyCardAmountGame2;
	int ItemCardAmountGame2;
	int SpellCardAmountGame2;
	int HogwartsCardAmountGame2;

	int AllyCardAmountGame3;
	int ItemCardAmountGame3;
	int SpellCardAmountGame3;
	int HogwartsCardAmountGame3;

	int AllyCardAmountGame4;
	int ItemCardAmountGame4;
	int SpellCardAmountGame4;
	int HogwartsCardAmountGame4;

	int AllyCardAmountGame5;
	int ItemCardAmountGame5;
	int SpellCardAmountGame5;
	int HogwartsCardAmountGame5;

	int AllyCardAmountGame6;
	int ItemCardAmountGame6;
	int SpellCardAmountGame6;
	int HogwartsCardAmountGame6;

	int AllyCardAmountGame7;
	int ItemCardAmountGame7;
	int SpellCardAmountGame7;
	int HogwartsCardAmountGame7;
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Change Scene
	public ChangeScene Scene11LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		SetLocationData();
		SetDarkArtsData();
		SetVillainData();
		SetHogwartsData();
		SetHorcruxData();
		SetProficiencyData();
		SetAbilityData();
		SetRemainingData();
		Scene11LoadRun.Scene11Load();
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	public void SetLocationData() {
		// Main Box
		if (DataPlayerSetup.PlayerBoxSelection == 1) {
			// Game 1
			if (DataPlayerSetup.PlayerBoxNumberSelection == 1) {
				// Set Location Data
				DataGameplayCards.LocationCardAmount = 2;
				DataGameplayCards.LocationCurrentCardAmount = 1;
				DataGameplayCards.LocationCurrentMarkerAmount = 0;
				DataGameplayCards.LocationCardNames.Add("Loc01");
				DataGameplayCards.LocationCardNames.Add("Loc02");
				DataGameplayCards.LocationActiveCard = "Loc01";
			}
			
			// Game 2
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 2) {
				// Set Location Data
				DataGameplayCards.LocationCardAmount = 3;
				DataGameplayCards.LocationCurrentCardAmount = 1;
				DataGameplayCards.LocationCurrentMarkerAmount = 0;
				DataGameplayCards.LocationCardNames.Add("Loc03");
				DataGameplayCards.LocationCardNames.Add("Loc04");
				DataGameplayCards.LocationCardNames.Add("Loc05");
				DataGameplayCards.LocationActiveCard = "Loc03";
			}

			// Game 3
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 3) {
				// Set Location Data
				DataGameplayCards.LocationCardAmount = 3;
				DataGameplayCards.LocationCurrentCardAmount = 1;
				DataGameplayCards.LocationCurrentMarkerAmount = 0;
				DataGameplayCards.LocationCardNames.Add("Loc06");
				DataGameplayCards.LocationCardNames.Add("Loc07");
				DataGameplayCards.LocationCardNames.Add("Loc08");
				DataGameplayCards.LocationActiveCard = "Loc06";
			}

			// Game 4
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 4) {
				// Set Location Data
				DataGameplayCards.LocationCardAmount = 3;
				DataGameplayCards.LocationCurrentCardAmount = 1;
				DataGameplayCards.LocationCurrentMarkerAmount = 0;
				DataGameplayCards.LocationCardNames.Add("Loc09");
				DataGameplayCards.LocationCardNames.Add("Loc10");
				DataGameplayCards.LocationCardNames.Add("Loc11");
				DataGameplayCards.LocationActiveCard = "Loc09";
			}

			// Game 5
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 5) {
				// Set Location Data
				DataGameplayCards.LocationCardAmount = 3;
				DataGameplayCards.LocationCurrentCardAmount = 1;
				DataGameplayCards.LocationCurrentMarkerAmount = 0;
				DataGameplayCards.LocationCardNames.Add("Loc12");
				DataGameplayCards.LocationCardNames.Add("Loc13");
				DataGameplayCards.LocationCardNames.Add("Loc14");
				DataGameplayCards.LocationActiveCard = "Loc12";
			}

			// Game 6
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 6) {
				// Set Location Data
				DataGameplayCards.LocationCardAmount = 3;
				DataGameplayCards.LocationCurrentCardAmount = 1;
				DataGameplayCards.LocationCurrentMarkerAmount = 0;
				DataGameplayCards.LocationCardNames.Add("Loc15");
				DataGameplayCards.LocationCardNames.Add("Loc16");
				DataGameplayCards.LocationCardNames.Add("Loc17");
				DataGameplayCards.LocationActiveCard = "Loc15";
			}

			// Game 7
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 7) {
				// Set Location Data
				DataGameplayCards.LocationCardAmount = 4;
				DataGameplayCards.LocationCurrentCardAmount = 1;
				DataGameplayCards.LocationCurrentMarkerAmount = 0;
				DataGameplayCards.LocationCardNames.Add("Loc18");
				DataGameplayCards.LocationCardNames.Add("Loc19");
				DataGameplayCards.LocationCardNames.Add("Loc20");
				DataGameplayCards.LocationCardNames.Add("Loc21");
				DataGameplayCards.LocationActiveCard = "Loc18";
			}

			// Game Extreme (8)
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 8) {
				// Set Location Data
				DataGameplayCards.LocationCardAmount = 7;
				DataGameplayCards.LocationCurrentCardAmount = 1;
				DataGameplayCards.LocationCurrentMarkerAmount = 0;
				DataGameplayCards.LocationCardNames.Add("Loc02");
				DataGameplayCards.LocationCardNames.Add("Loc05");
				DataGameplayCards.LocationCardNames.Add("Loc08");
				DataGameplayCards.LocationCardNames.Add("Loc11");
				DataGameplayCards.LocationCardNames.Add("Loc14");
				DataGameplayCards.LocationCardNames.Add("Loc17");
				DataGameplayCards.LocationCardNames.Add("Loc21");
				DataGameplayCards.LocationActiveCard = "Loc02";
			}
		}
	}

	public void SetDarkArtsData() {
		// Main Box
		if (DataPlayerSetup.PlayerBoxSelection == 1) {
			// Game 1
			if (DataPlayerSetup.PlayerBoxNumberSelection == 1) {
				// Set Dark Arts Data
				DataGameplayCards.DarkArtsCardAmount = 10;
				DataGameplayCards.DarkArtsDeckAmount = 10;
				DataGameplayCards.DarkArtsDiscardAmount = 0;
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
			}

			// Game 2
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 2) {
				// Set Dark Arts Data
				DataGameplayCards.DarkArtsCardAmount = 15;
				DataGameplayCards.DarkArtsDeckAmount = 15;
				DataGameplayCards.DarkArtsDiscardAmount = 0;
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark06");
				DataGameplayCards.DarkArtsCardNames.Add("Dark07");
				DataGameplayCards.DarkArtsCardNames.Add("Dark08");
			}

			// Game 3
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 3) {
				// Set Dark Arts Data
				DataGameplayCards.DarkArtsCardAmount = 19;
				DataGameplayCards.DarkArtsDeckAmount = 19;
				DataGameplayCards.DarkArtsDiscardAmount = 0;
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark06");
				DataGameplayCards.DarkArtsCardNames.Add("Dark07");
				DataGameplayCards.DarkArtsCardNames.Add("Dark08");
				DataGameplayCards.DarkArtsCardNames.Add("Dark09");
				DataGameplayCards.DarkArtsCardNames.Add("Dark10");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
			}

			// Game 4
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 4) {
				// Set Dark Arts Data
				DataGameplayCards.DarkArtsCardAmount = 27;
				DataGameplayCards.DarkArtsDeckAmount = 27;
				DataGameplayCards.DarkArtsDiscardAmount = 0;
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark06");
				DataGameplayCards.DarkArtsCardNames.Add("Dark07");
				DataGameplayCards.DarkArtsCardNames.Add("Dark08");
				DataGameplayCards.DarkArtsCardNames.Add("Dark09");
				DataGameplayCards.DarkArtsCardNames.Add("Dark10");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark12");
				DataGameplayCards.DarkArtsCardNames.Add("Dark13");
				DataGameplayCards.DarkArtsCardNames.Add("Dark14");
				DataGameplayCards.DarkArtsCardNames.Add("Dark15");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
			}

			// Game 5
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 5) {
				// Set Dark Arts Data
				DataGameplayCards.DarkArtsCardAmount = 34;
				DataGameplayCards.DarkArtsDeckAmount = 34;
				DataGameplayCards.DarkArtsDiscardAmount = 0;
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark06");
				DataGameplayCards.DarkArtsCardNames.Add("Dark07");
				DataGameplayCards.DarkArtsCardNames.Add("Dark08");
				DataGameplayCards.DarkArtsCardNames.Add("Dark09");
				DataGameplayCards.DarkArtsCardNames.Add("Dark10");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark12");
				DataGameplayCards.DarkArtsCardNames.Add("Dark13");
				DataGameplayCards.DarkArtsCardNames.Add("Dark14");
				DataGameplayCards.DarkArtsCardNames.Add("Dark15");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
				DataGameplayCards.DarkArtsCardNames.Add("Dark18");
				DataGameplayCards.DarkArtsCardNames.Add("Dark19");
				DataGameplayCards.DarkArtsCardNames.Add("Dark19");
				DataGameplayCards.DarkArtsCardNames.Add("Dark20");
				DataGameplayCards.DarkArtsCardNames.Add("Dark21");
				DataGameplayCards.DarkArtsCardNames.Add("Dark22");
				DataGameplayCards.DarkArtsCardNames.Add("Dark23");
			}

			// Game 6
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 6) {
				// Set Dark Arts Data
				DataGameplayCards.DarkArtsCardAmount = 37;
				DataGameplayCards.DarkArtsDeckAmount = 37;
				DataGameplayCards.DarkArtsDiscardAmount = 0;
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark06");
				DataGameplayCards.DarkArtsCardNames.Add("Dark07");
				DataGameplayCards.DarkArtsCardNames.Add("Dark08");
				DataGameplayCards.DarkArtsCardNames.Add("Dark09");
				DataGameplayCards.DarkArtsCardNames.Add("Dark10");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark12");
				DataGameplayCards.DarkArtsCardNames.Add("Dark13");
				DataGameplayCards.DarkArtsCardNames.Add("Dark14");
				DataGameplayCards.DarkArtsCardNames.Add("Dark15");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
				DataGameplayCards.DarkArtsCardNames.Add("Dark18");
				DataGameplayCards.DarkArtsCardNames.Add("Dark19");
				DataGameplayCards.DarkArtsCardNames.Add("Dark19");
				DataGameplayCards.DarkArtsCardNames.Add("Dark20");
				DataGameplayCards.DarkArtsCardNames.Add("Dark21");
				DataGameplayCards.DarkArtsCardNames.Add("Dark22");
				DataGameplayCards.DarkArtsCardNames.Add("Dark23");
				DataGameplayCards.DarkArtsCardNames.Add("Dark24");
				DataGameplayCards.DarkArtsCardNames.Add("Dark24");
				DataGameplayCards.DarkArtsCardNames.Add("Dark25");
			}

			// Game 7
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 7) {
				// Set Dark Arts Data
				DataGameplayCards.DarkArtsCardAmount = 41;
				DataGameplayCards.DarkArtsDeckAmount = 41;
				DataGameplayCards.DarkArtsDiscardAmount = 0;
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark06");
				DataGameplayCards.DarkArtsCardNames.Add("Dark07");
				DataGameplayCards.DarkArtsCardNames.Add("Dark08");
				DataGameplayCards.DarkArtsCardNames.Add("Dark09");
				DataGameplayCards.DarkArtsCardNames.Add("Dark10");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark12");
				DataGameplayCards.DarkArtsCardNames.Add("Dark13");
				DataGameplayCards.DarkArtsCardNames.Add("Dark14");
				DataGameplayCards.DarkArtsCardNames.Add("Dark15");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
				DataGameplayCards.DarkArtsCardNames.Add("Dark18");
				DataGameplayCards.DarkArtsCardNames.Add("Dark19");
				DataGameplayCards.DarkArtsCardNames.Add("Dark19");
				DataGameplayCards.DarkArtsCardNames.Add("Dark20");
				DataGameplayCards.DarkArtsCardNames.Add("Dark21");
				DataGameplayCards.DarkArtsCardNames.Add("Dark22");
				DataGameplayCards.DarkArtsCardNames.Add("Dark23");
				DataGameplayCards.DarkArtsCardNames.Add("Dark24");
				DataGameplayCards.DarkArtsCardNames.Add("Dark24");
				DataGameplayCards.DarkArtsCardNames.Add("Dark25");
				DataGameplayCards.DarkArtsCardNames.Add("Dark26");
				DataGameplayCards.DarkArtsCardNames.Add("Dark27");
				DataGameplayCards.DarkArtsCardNames.Add("Dark28");
				DataGameplayCards.DarkArtsCardNames.Add("Dark29");
			}

			// Game Extreme (8)
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 8) {
				// Set Dark Arts Data
				DataGameplayCards.DarkArtsCardAmount = 41;
				DataGameplayCards.DarkArtsDeckAmount = 41;
				DataGameplayCards.DarkArtsDiscardAmount = 0;
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark01");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark02");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark03");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark04");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark05");
				DataGameplayCards.DarkArtsCardNames.Add("Dark06");
				DataGameplayCards.DarkArtsCardNames.Add("Dark07");
				DataGameplayCards.DarkArtsCardNames.Add("Dark08");
				DataGameplayCards.DarkArtsCardNames.Add("Dark09");
				DataGameplayCards.DarkArtsCardNames.Add("Dark10");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark11");
				DataGameplayCards.DarkArtsCardNames.Add("Dark12");
				DataGameplayCards.DarkArtsCardNames.Add("Dark13");
				DataGameplayCards.DarkArtsCardNames.Add("Dark14");
				DataGameplayCards.DarkArtsCardNames.Add("Dark15");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark16");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
				DataGameplayCards.DarkArtsCardNames.Add("Dark17");
				DataGameplayCards.DarkArtsCardNames.Add("Dark18");
				DataGameplayCards.DarkArtsCardNames.Add("Dark19");
				DataGameplayCards.DarkArtsCardNames.Add("Dark19");
				DataGameplayCards.DarkArtsCardNames.Add("Dark20");
				DataGameplayCards.DarkArtsCardNames.Add("Dark21");
				DataGameplayCards.DarkArtsCardNames.Add("Dark22");
				DataGameplayCards.DarkArtsCardNames.Add("Dark23");
				DataGameplayCards.DarkArtsCardNames.Add("Dark24");
				DataGameplayCards.DarkArtsCardNames.Add("Dark24");
				DataGameplayCards.DarkArtsCardNames.Add("Dark25");
				DataGameplayCards.DarkArtsCardNames.Add("Dark26");
				DataGameplayCards.DarkArtsCardNames.Add("Dark27");
				DataGameplayCards.DarkArtsCardNames.Add("Dark28");
				DataGameplayCards.DarkArtsCardNames.Add("Dark29");
			}
		}
	}

	public void SetVillainData() {
		// Main Box
		if (DataPlayerSetup.PlayerBoxSelection == 1) {
			// Game 1
			if (DataPlayerSetup.PlayerBoxNumberSelection == 1) {
				// Set Villain Data
				DataGameplayCards.VillainCardAmount = 3;
				DataGameplayCards.VillainCardNames.Add("Vill01");
				DataGameplayCards.VillainCardNames.Add("Vill02");
				DataGameplayCards.VillainCardNames.Add("Vill03");
				DataGameplayCards.VillainSlot1Used = true;
				DataGameplayCards.VillainSlot2Used = false;
				DataGameplayCards.VillainSlot3Used = false;
				DataGameplayCards.VillainSlot4Used = false;
			}

			// Game 2
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 2) {
				// Set Villain Data
				DataGameplayCards.VillainCardAmount = 6;
				DataGameplayCards.VillainCardNames.Add("Vill01");
				DataGameplayCards.VillainCardNames.Add("Vill02");
				DataGameplayCards.VillainCardNames.Add("Vill03");
				DataGameplayCards.VillainCardNames.Add("Vill04");
				DataGameplayCards.VillainCardNames.Add("Vill05");
				DataGameplayCards.VillainCardNames.Add("Vill06");
				DataGameplayCards.VillainSlot1Used = true;
				DataGameplayCards.VillainSlot2Used = false;
				DataGameplayCards.VillainSlot3Used = false;
				DataGameplayCards.VillainSlot4Used = false;
			}

			// Game 3
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 3) {
				// Set Villain Data
				DataGameplayCards.VillainCardAmount = 8;
				DataGameplayCards.VillainCardNames.Add("Vill01");
				DataGameplayCards.VillainCardNames.Add("Vill02");
				DataGameplayCards.VillainCardNames.Add("Vill03");
				DataGameplayCards.VillainCardNames.Add("Vill04");
				DataGameplayCards.VillainCardNames.Add("Vill05");
				DataGameplayCards.VillainCardNames.Add("Vill06");
				DataGameplayCards.VillainCardNames.Add("Vill07");
				DataGameplayCards.VillainCardNames.Add("Vill08");
				DataGameplayCards.VillainSlot1Used = true;
				DataGameplayCards.VillainSlot2Used = true;
				DataGameplayCards.VillainSlot3Used = false;
				DataGameplayCards.VillainSlot4Used = false;
			}

			// Game 4
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 4) {
				// Set Villain Data
				DataGameplayCards.VillainCardAmount = 10;
				DataGameplayCards.VillainCardNames.Add("Vill01");
				DataGameplayCards.VillainCardNames.Add("Vill02");
				DataGameplayCards.VillainCardNames.Add("Vill03");
				DataGameplayCards.VillainCardNames.Add("Vill04");
				DataGameplayCards.VillainCardNames.Add("Vill05");
				DataGameplayCards.VillainCardNames.Add("Vill06");
				DataGameplayCards.VillainCardNames.Add("Vill07");
				DataGameplayCards.VillainCardNames.Add("Vill08");
				DataGameplayCards.VillainCardNames.Add("Vill09");
				DataGameplayCards.VillainCardNames.Add("Vill10");
				DataGameplayCards.VillainSlot1Used = true;
				DataGameplayCards.VillainSlot2Used = true;
				DataGameplayCards.VillainSlot3Used = false;
				DataGameplayCards.VillainSlot4Used = false;
			}

			// Game 5
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 5) {
				// Set Villain Data
				DataGameplayCards.VillainCardAmount = 13;
				DataGameplayCards.VillainCardNames.Add("Vill01");
				DataGameplayCards.VillainCardNames.Add("Vill02");
				DataGameplayCards.VillainCardNames.Add("Vill03");
				DataGameplayCards.VillainCardNames.Add("Vill04");
				DataGameplayCards.VillainCardNames.Add("Vill05");
				DataGameplayCards.VillainCardNames.Add("Vill06");
				DataGameplayCards.VillainCardNames.Add("Vill07");
				DataGameplayCards.VillainCardNames.Add("Vill08");
				DataGameplayCards.VillainCardNames.Add("Vill09");
				DataGameplayCards.VillainCardNames.Add("Vill10");
				DataGameplayCards.VillainCardNames.Add("Vill11"); // Voldemort Game 5
				DataGameplayCards.VillainCardNames.Add("Vill12");
				DataGameplayCards.VillainCardNames.Add("Vill13");
				DataGameplayCards.VillainSlot1Used = true;
				DataGameplayCards.VillainSlot2Used = true;
				DataGameplayCards.VillainSlot3Used = true;
				DataGameplayCards.VillainSlot4Used = true;
			}

			// Game 6
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 6) {
				// Set Villain Data
				DataGameplayCards.VillainCardAmount = 15;
				DataGameplayCards.VillainCardNames.Add("Vill01");
				DataGameplayCards.VillainCardNames.Add("Vill02");
				DataGameplayCards.VillainCardNames.Add("Vill03");
				DataGameplayCards.VillainCardNames.Add("Vill04");
				DataGameplayCards.VillainCardNames.Add("Vill05");
				DataGameplayCards.VillainCardNames.Add("Vill06");
				DataGameplayCards.VillainCardNames.Add("Vill07");
				DataGameplayCards.VillainCardNames.Add("Vill08");
				DataGameplayCards.VillainCardNames.Add("Vill09");
				DataGameplayCards.VillainCardNames.Add("Vill10");
				DataGameplayCards.VillainCardNames.Add("Vill12");
				DataGameplayCards.VillainCardNames.Add("Vill13");
				DataGameplayCards.VillainCardNames.Add("Vill14");
				DataGameplayCards.VillainCardNames.Add("Vill15"); // Voldemort Game 6
				DataGameplayCards.VillainCardNames.Add("Vill16");
				DataGameplayCards.VillainSlot1Used = true;
				DataGameplayCards.VillainSlot2Used = true;
				DataGameplayCards.VillainSlot3Used = true;
				DataGameplayCards.VillainSlot4Used = true;
			}

			// Game 7
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 7) {
				// Set Villain Data
				DataGameplayCards.VillainCardAmount = 15;
				DataGameplayCards.VillainCardNames.Add("Vill01");
				DataGameplayCards.VillainCardNames.Add("Vill02");
				DataGameplayCards.VillainCardNames.Add("Vill03");
				DataGameplayCards.VillainCardNames.Add("Vill04");
				DataGameplayCards.VillainCardNames.Add("Vill05");
				DataGameplayCards.VillainCardNames.Add("Vill06");
				DataGameplayCards.VillainCardNames.Add("Vill07");
				DataGameplayCards.VillainCardNames.Add("Vill08");
				DataGameplayCards.VillainCardNames.Add("Vill09");
				DataGameplayCards.VillainCardNames.Add("Vill10");
				DataGameplayCards.VillainCardNames.Add("Vill12");
				DataGameplayCards.VillainCardNames.Add("Vill13");
				DataGameplayCards.VillainCardNames.Add("Vill14");
				DataGameplayCards.VillainCardNames.Add("Vill16");
				DataGameplayCards.VillainCardNames.Add("Vill17"); // Voldemort Game 7
				DataGameplayCards.VillainSlot1Used = true;
				DataGameplayCards.VillainSlot2Used = true;
				DataGameplayCards.VillainSlot3Used = true;
				DataGameplayCards.VillainSlot4Used = true;
			}

			// Game Extreme (8)
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 8) {
				// Set Villain Data
				DataGameplayCards.VillainCardAmount = 17;
				DataGameplayCards.VillainCardNames.Add("Vill01");
				DataGameplayCards.VillainCardNames.Add("Vill02");
				DataGameplayCards.VillainCardNames.Add("Vill03");
				DataGameplayCards.VillainCardNames.Add("Vill04");
				DataGameplayCards.VillainCardNames.Add("Vill05");
				DataGameplayCards.VillainCardNames.Add("Vill06");
				DataGameplayCards.VillainCardNames.Add("Vill07");
				DataGameplayCards.VillainCardNames.Add("Vill08");
				DataGameplayCards.VillainCardNames.Add("Vill09");
				DataGameplayCards.VillainCardNames.Add("Vill10");
				DataGameplayCards.VillainCardNames.Add("Vill11"); // Voldemort Game 5
				DataGameplayCards.VillainCardNames.Add("Vill12");
				DataGameplayCards.VillainCardNames.Add("Vill13");
				DataGameplayCards.VillainCardNames.Add("Vill14");
				DataGameplayCards.VillainCardNames.Add("Vill15"); // Voldemort Game 6
				DataGameplayCards.VillainCardNames.Add("Vill16");
				DataGameplayCards.VillainCardNames.Add("Vill17"); // Voldemort Game 7
				DataGameplayCards.VillainSlot1Used = true;
				DataGameplayCards.VillainSlot2Used = true;
				DataGameplayCards.VillainSlot3Used = true;
				DataGameplayCards.VillainSlot4Used = true;
			}
		}
	}

	public void SetHogwartsData() {
		// Main Box
		if (DataPlayerSetup.PlayerBoxSelection == 1) {
			// Game 1
			if (DataPlayerSetup.PlayerBoxNumberSelection == 1) {
				// Set Hogwarts Data
				SetHogwartsGame0Data();
				SetHogwartsGame1Data();
				DataGameplayCards.HogwartsCardAmount = HogwartsCardAmountGame0 + HogwartsCardAmountGame1;
			}

			// Game 2
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 2) {
				// Set Hogwarts Data
				SetHogwartsGame0Data();
				SetHogwartsGame1Data();
				SetHogwartsGame2Data();
				DataGameplayCards.HogwartsCardAmount = HogwartsCardAmountGame0 + HogwartsCardAmountGame1 + HogwartsCardAmountGame2;
			}

			// Game 3
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 3) {
				// Set Hogwarts Data
				SetHogwartsGame0Data();
				SetHogwartsGame1Data();
				SetHogwartsGame2Data();
				SetHogwartsGame3Data();
				DataGameplayCards.HogwartsCardAmount = HogwartsCardAmountGame0 + HogwartsCardAmountGame1 + HogwartsCardAmountGame2 + HogwartsCardAmountGame3;
			}

			// Game 4
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 4) {
				// Set Hogwarts Data
				SetHogwartsGame0Data();
				SetHogwartsGame1Data();
				SetHogwartsGame2Data();
				SetHogwartsGame3Data();
				SetHogwartsGame4Data();
				DataGameplayCards.HogwartsCardAmount = HogwartsCardAmountGame0 + HogwartsCardAmountGame1 + HogwartsCardAmountGame2 + HogwartsCardAmountGame3 + HogwartsCardAmountGame4;
			}

			// Game 5
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 5) {
				// Set Hogwarts Data
				SetHogwartsGame0Data();
				SetHogwartsGame1Data();
				SetHogwartsGame2Data();
				SetHogwartsGame3Data();
				SetHogwartsGame4Data();
				SetHogwartsGame5Data();
				DataGameplayCards.HogwartsCardAmount = HogwartsCardAmountGame0 + HogwartsCardAmountGame1 + HogwartsCardAmountGame2 + HogwartsCardAmountGame3 + HogwartsCardAmountGame4 + HogwartsCardAmountGame5;
			}

			// Game 6
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 6) {
				// Set Hogwarts Data
				SetHogwartsGame0Data();
				SetHogwartsGame1Data();
				SetHogwartsGame2Data();
				SetHogwartsGame3Data();
				SetHogwartsGame4Data();
				SetHogwartsGame5Data();
				SetHogwartsGame6Data();
				DataGameplayCards.HogwartsCardAmount = HogwartsCardAmountGame0 + HogwartsCardAmountGame1 + HogwartsCardAmountGame2 + HogwartsCardAmountGame3 + HogwartsCardAmountGame4 + HogwartsCardAmountGame5 + HogwartsCardAmountGame6;
			}

			// Game 7
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 7) {
				// Set Hogwarts Data
				SetHogwartsGame0Data();
				SetHogwartsGame1Data();
				SetHogwartsGame2Data();
				SetHogwartsGame3Data();
				SetHogwartsGame4Data();
				SetHogwartsGame5Data();
				SetHogwartsGame6Data();
				SetHogwartsGame7Data();
				DataGameplayCards.HogwartsCardAmount = HogwartsCardAmountGame0 + HogwartsCardAmountGame1 + HogwartsCardAmountGame2 + HogwartsCardAmountGame3 + HogwartsCardAmountGame4 + HogwartsCardAmountGame5 + HogwartsCardAmountGame6 + HogwartsCardAmountGame7;
			}

			// Game Extreme (8)
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 8) {
				// Set Hogwarts Data
				SetHogwartsGame0Data();
				SetHogwartsGame1Data();
				SetHogwartsGame2Data();
				SetHogwartsGame3Data();
				SetHogwartsGame4Data();
				SetHogwartsGame5Data();
				SetHogwartsGame6Data();
				SetHogwartsGame7Data();
				DataGameplayCards.HogwartsCardAmount = HogwartsCardAmountGame0 + HogwartsCardAmountGame1 + HogwartsCardAmountGame2 + HogwartsCardAmountGame3 + HogwartsCardAmountGame4 + HogwartsCardAmountGame5 + HogwartsCardAmountGame6 + HogwartsCardAmountGame7;
			}
		}
	}

	public void SetHorcruxData() {
		// Main Box
		if (DataPlayerSetup.PlayerBoxSelection == 1) {
			// Game 7
			if (DataPlayerSetup.PlayerBoxNumberSelection == 7) {
				// Set Horcrux Data
				DataGameplayCards.HorcruxCardAmount = 6;
				DataGameplayCards.HorcruxCardNames.Add("Horc01");
				DataGameplayCards.HorcruxCardNames.Add("Horc02");
				DataGameplayCards.HorcruxCardNames.Add("Horc03");
				DataGameplayCards.HorcruxCardNames.Add("Horc04");
				DataGameplayCards.HorcruxCardNames.Add("Horc05");
				DataGameplayCards.HorcruxCardNames.Add("Horc06");
			}

			// Game Extreme (8)
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 8) {
				// Set Horcrux Data
				DataGameplayCards.HorcruxCardAmount = 6;
				DataGameplayCards.HorcruxCardNames.Add("Horc01");
				DataGameplayCards.HorcruxCardNames.Add("Horc02");
				DataGameplayCards.HorcruxCardNames.Add("Horc03");
				DataGameplayCards.HorcruxCardNames.Add("Horc04");
				DataGameplayCards.HorcruxCardNames.Add("Horc05");
				DataGameplayCards.HorcruxCardNames.Add("Horc06");
			}

			else {
				// Set Horcrux Data
				DataGameplayCards.HorcruxCardAmount = 0;
				// None Added
			}
		}
	}

	public void SetProficiencyData() {
		// Main Box
		if (DataPlayerSetup.PlayerBoxSelection == 1) {
			// Game 6
			if (DataPlayerSetup.PlayerBoxNumberSelection == 6) {
				// Set Proficiency Data
				DataGameplayCards.ProficiencyCardAmount = 9;
				DataGameplayCards.ProficiencyCardNames.Add("Prof01");
				DataGameplayCards.ProficiencyCardNames.Add("Prof02");
				DataGameplayCards.ProficiencyCardNames.Add("Prof03");
				DataGameplayCards.ProficiencyCardNames.Add("Prof04");
				DataGameplayCards.ProficiencyCardNames.Add("Prof05");
				DataGameplayCards.ProficiencyCardNames.Add("Prof06");
				DataGameplayCards.ProficiencyCardNames.Add("Prof07");
				DataGameplayCards.ProficiencyCardNames.Add("Prof08");
				DataGameplayCards.ProficiencyCardNames.Add("Prof09");
			}

			// Game 7
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 7) {
				// Set Proficiency Data
				DataGameplayCards.ProficiencyCardAmount = 9;
				DataGameplayCards.ProficiencyCardNames.Add("Prof01");
				DataGameplayCards.ProficiencyCardNames.Add("Prof02");
				DataGameplayCards.ProficiencyCardNames.Add("Prof03");
				DataGameplayCards.ProficiencyCardNames.Add("Prof04");
				DataGameplayCards.ProficiencyCardNames.Add("Prof05");
				DataGameplayCards.ProficiencyCardNames.Add("Prof06");
				DataGameplayCards.ProficiencyCardNames.Add("Prof07");
				DataGameplayCards.ProficiencyCardNames.Add("Prof08");
				DataGameplayCards.ProficiencyCardNames.Add("Prof09");
			}

			// Game Extreme (8)
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 8) {
				// Set Proficiency Data
				DataGameplayCards.ProficiencyCardAmount = 9;
				DataGameplayCards.ProficiencyCardNames.Add("Prof01");
				DataGameplayCards.ProficiencyCardNames.Add("Prof02");
				DataGameplayCards.ProficiencyCardNames.Add("Prof03");
				DataGameplayCards.ProficiencyCardNames.Add("Prof04");
				DataGameplayCards.ProficiencyCardNames.Add("Prof05");
				DataGameplayCards.ProficiencyCardNames.Add("Prof06");
				DataGameplayCards.ProficiencyCardNames.Add("Prof07");
				DataGameplayCards.ProficiencyCardNames.Add("Prof08");
				DataGameplayCards.ProficiencyCardNames.Add("Prof09");
			}

			else {
				// Set Proficiency Data
				DataGameplayCards.ProficiencyCardAmount = 0;
				// None Added
			}
		}
	}

	public void SetAbilityData() {
		// Main Box
		if (DataPlayerSetup.PlayerBoxSelection == 1) {
			// Game 1
			if (DataPlayerSetup.PlayerBoxNumberSelection == 1) {
				// Set Ability Data
				DataGameplayCards.AbilityCardAmount = 4;
				DataGameplayCards.AbilityCardNames.Add("Hero01");
				DataGameplayCards.AbilityCardNames.Add("Hero02");
				DataGameplayCards.AbilityCardNames.Add("Hero03");
				DataGameplayCards.AbilityCardNames.Add("Hero04");
			}

			// Game 2
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 2) {
				// Set Ability Data
				DataGameplayCards.AbilityCardAmount = 4;
				DataGameplayCards.AbilityCardNames.Add("Hero01");
				DataGameplayCards.AbilityCardNames.Add("Hero02");
				DataGameplayCards.AbilityCardNames.Add("Hero03");
				DataGameplayCards.AbilityCardNames.Add("Hero04");
			}

			// Game 3
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 3) {
				// Set Ability Data
				DataGameplayCards.AbilityCardAmount = 4;
				DataGameplayCards.AbilityCardNames.Add("Hero05");
				DataGameplayCards.AbilityCardNames.Add("Hero06");
				DataGameplayCards.AbilityCardNames.Add("Hero07");
				DataGameplayCards.AbilityCardNames.Add("Hero08");
			}

			// Game 4
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 4) {
				// Set Ability Data
				DataGameplayCards.AbilityCardAmount = 4;
				DataGameplayCards.AbilityCardNames.Add("Hero05");
				DataGameplayCards.AbilityCardNames.Add("Hero06");
				DataGameplayCards.AbilityCardNames.Add("Hero07");
				DataGameplayCards.AbilityCardNames.Add("Hero08");
			}

			// Game 5
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 5) {
				// Set Ability Data
				DataGameplayCards.AbilityCardAmount = 4;
				DataGameplayCards.AbilityCardNames.Add("Hero05");
				DataGameplayCards.AbilityCardNames.Add("Hero06");
				DataGameplayCards.AbilityCardNames.Add("Hero07");
				DataGameplayCards.AbilityCardNames.Add("Hero08");
			}

			// Game 6
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 6) {
				// Set Ability Data
				DataGameplayCards.AbilityCardAmount = 4;
				DataGameplayCards.AbilityCardNames.Add("Hero05");
				DataGameplayCards.AbilityCardNames.Add("Hero06");
				DataGameplayCards.AbilityCardNames.Add("Hero07");
				DataGameplayCards.AbilityCardNames.Add("Hero08");
			}

			// Game 7
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 7) {
				// Set Ability Data
				DataGameplayCards.AbilityCardAmount = 4;
				DataGameplayCards.AbilityCardNames.Add("Hero09");
				DataGameplayCards.AbilityCardNames.Add("Hero10");
				DataGameplayCards.AbilityCardNames.Add("Hero11");
				DataGameplayCards.AbilityCardNames.Add("Hero12");
			}

			// Game Extreme (8)
			else if (DataPlayerSetup.PlayerBoxNumberSelection == 8) {
				// Set Ability Data
				DataGameplayCards.AbilityCardAmount = 4;
				DataGameplayCards.AbilityCardNames.Add("Hero09");
				DataGameplayCards.AbilityCardNames.Add("Hero10");
				DataGameplayCards.AbilityCardNames.Add("Hero11");
				DataGameplayCards.AbilityCardNames.Add("Hero12");
			}
		}
	}

	public void SetHogwartsGame0Data() {
		AllyCardAmountGame0 = 4;
		SpellCardAmountGame0 = 28;
		ItemCardAmountGame0 = 8;
		HogwartsCardAmountGame0 = AllyCardAmountGame0 + ItemCardAmountGame0 + SpellCardAmountGame0;

		// Harry Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally02");
		DataGameplayCards.HogwartsCardNames.Add("Spl02");
		DataGameplayCards.HogwartsCardNames.Add("Spl02");
		DataGameplayCards.HogwartsCardNames.Add("Spl02");
		DataGameplayCards.HogwartsCardNames.Add("Spl02");
		DataGameplayCards.HogwartsCardNames.Add("Spl02");
		DataGameplayCards.HogwartsCardNames.Add("Spl02");
		DataGameplayCards.HogwartsCardNames.Add("Spl02");
		DataGameplayCards.HogwartsCardNames.Add("Item03");
		DataGameplayCards.HogwartsCardNames.Add("Item04");

		// Hermione Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally01");
		DataGameplayCards.HogwartsCardNames.Add("Spl01");
		DataGameplayCards.HogwartsCardNames.Add("Spl01");
		DataGameplayCards.HogwartsCardNames.Add("Spl01");
		DataGameplayCards.HogwartsCardNames.Add("Spl01");
		DataGameplayCards.HogwartsCardNames.Add("Spl01");
		DataGameplayCards.HogwartsCardNames.Add("Spl01");
		DataGameplayCards.HogwartsCardNames.Add("Spl01");
		DataGameplayCards.HogwartsCardNames.Add("Item01");
		DataGameplayCards.HogwartsCardNames.Add("Item02");

		// Neville Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally03");
		DataGameplayCards.HogwartsCardNames.Add("Spl03");
		DataGameplayCards.HogwartsCardNames.Add("Spl03");
		DataGameplayCards.HogwartsCardNames.Add("Spl03");
		DataGameplayCards.HogwartsCardNames.Add("Spl03");
		DataGameplayCards.HogwartsCardNames.Add("Spl03");
		DataGameplayCards.HogwartsCardNames.Add("Spl03");
		DataGameplayCards.HogwartsCardNames.Add("Spl03");
		DataGameplayCards.HogwartsCardNames.Add("Item05");
		DataGameplayCards.HogwartsCardNames.Add("Item06");

		// Ron Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally04");
		DataGameplayCards.HogwartsCardNames.Add("Spl04");
		DataGameplayCards.HogwartsCardNames.Add("Spl04");
		DataGameplayCards.HogwartsCardNames.Add("Spl04");
		DataGameplayCards.HogwartsCardNames.Add("Spl04");
		DataGameplayCards.HogwartsCardNames.Add("Spl04");
		DataGameplayCards.HogwartsCardNames.Add("Spl04");
		DataGameplayCards.HogwartsCardNames.Add("Spl04");
		DataGameplayCards.HogwartsCardNames.Add("Item07");
		DataGameplayCards.HogwartsCardNames.Add("Item08");
	}

	public void SetHogwartsGame1Data() {
		AllyCardAmountGame1 = 3;
		SpellCardAmountGame1 = 17;
		ItemCardAmountGame1 = 10;
		HogwartsCardAmountGame1 = AllyCardAmountGame1 + ItemCardAmountGame1 + SpellCardAmountGame1;

		// Deck Ally Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally05");
		DataGameplayCards.HogwartsCardNames.Add("Ally06");
		DataGameplayCards.HogwartsCardNames.Add("Ally07");

		// Deck Spell Cards
		DataGameplayCards.HogwartsCardNames.Add("Spl05");
		DataGameplayCards.HogwartsCardNames.Add("Spl05");
		DataGameplayCards.HogwartsCardNames.Add("Spl05");
		DataGameplayCards.HogwartsCardNames.Add("Spl06");
		DataGameplayCards.HogwartsCardNames.Add("Spl06");
		DataGameplayCards.HogwartsCardNames.Add("Spl07");
		DataGameplayCards.HogwartsCardNames.Add("Spl07");
		DataGameplayCards.HogwartsCardNames.Add("Spl07");
		DataGameplayCards.HogwartsCardNames.Add("Spl07");
		DataGameplayCards.HogwartsCardNames.Add("Spl07");
		DataGameplayCards.HogwartsCardNames.Add("Spl07");
		DataGameplayCards.HogwartsCardNames.Add("Spl08");
		DataGameplayCards.HogwartsCardNames.Add("Spl08");
		DataGameplayCards.HogwartsCardNames.Add("Spl09");
		DataGameplayCards.HogwartsCardNames.Add("Spl09");
		DataGameplayCards.HogwartsCardNames.Add("Spl09");
		DataGameplayCards.HogwartsCardNames.Add("Spl09");

		// Deck Item Cards
		DataGameplayCards.HogwartsCardNames.Add("Item09");
		DataGameplayCards.HogwartsCardNames.Add("Item09");
		DataGameplayCards.HogwartsCardNames.Add("Item09");
		DataGameplayCards.HogwartsCardNames.Add("Item09");
		DataGameplayCards.HogwartsCardNames.Add("Item10");
		DataGameplayCards.HogwartsCardNames.Add("Item10");
		DataGameplayCards.HogwartsCardNames.Add("Item10");
		DataGameplayCards.HogwartsCardNames.Add("Item10");
		DataGameplayCards.HogwartsCardNames.Add("Item11");
		DataGameplayCards.HogwartsCardNames.Add("Item12");
	}

	public void SetHogwartsGame2Data() {
		AllyCardAmountGame2 = 6;
		SpellCardAmountGame2 = 4;
		ItemCardAmountGame2 = 0;
		HogwartsCardAmountGame2 = AllyCardAmountGame2 + ItemCardAmountGame2 + SpellCardAmountGame2;

		// Deck Ally Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally08");
		DataGameplayCards.HogwartsCardNames.Add("Ally09");
		DataGameplayCards.HogwartsCardNames.Add("Ally10");
		DataGameplayCards.HogwartsCardNames.Add("Ally11");
		DataGameplayCards.HogwartsCardNames.Add("Ally12");
		DataGameplayCards.HogwartsCardNames.Add("Ally13");

		// Deck Spell Cards
		DataGameplayCards.HogwartsCardNames.Add("Spl10");
		DataGameplayCards.HogwartsCardNames.Add("Spl10");
		DataGameplayCards.HogwartsCardNames.Add("Spl11");
		DataGameplayCards.HogwartsCardNames.Add("Spl11");

		// Deck Item Cards
		DataGameplayCards.HogwartsCardNames.Add("Item13");
		DataGameplayCards.HogwartsCardNames.Add("Item13");
		DataGameplayCards.HogwartsCardNames.Add("Item14");
		DataGameplayCards.HogwartsCardNames.Add("Item14");
	}

	public void SetHogwartsGame3Data() {
		AllyCardAmountGame3 = 3;
		SpellCardAmountGame3 = 4;
		ItemCardAmountGame3 = 9;
		HogwartsCardAmountGame3 = AllyCardAmountGame3 + ItemCardAmountGame3 + SpellCardAmountGame3;

		// Deck Ally Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally14");
		DataGameplayCards.HogwartsCardNames.Add("Ally15");
		DataGameplayCards.HogwartsCardNames.Add("Ally16");

		// Deck Spell Cards
		DataGameplayCards.HogwartsCardNames.Add("Spl12");
		DataGameplayCards.HogwartsCardNames.Add("Spl12");
		DataGameplayCards.HogwartsCardNames.Add("Spl13");
		DataGameplayCards.HogwartsCardNames.Add("Spl13");

		// Deck Item Cards
		DataGameplayCards.HogwartsCardNames.Add("Item15");
		DataGameplayCards.HogwartsCardNames.Add("Item16");
		DataGameplayCards.HogwartsCardNames.Add("Item16");
		DataGameplayCards.HogwartsCardNames.Add("Item17");
		DataGameplayCards.HogwartsCardNames.Add("Item17");
		DataGameplayCards.HogwartsCardNames.Add("Item17");
		DataGameplayCards.HogwartsCardNames.Add("Item18");
		DataGameplayCards.HogwartsCardNames.Add("Item18");
		DataGameplayCards.HogwartsCardNames.Add("Item18");
	}

	public void SetHogwartsGame4Data() {
		AllyCardAmountGame4 = 8;
		SpellCardAmountGame4 = 5;
		ItemCardAmountGame4 = 8;
		HogwartsCardAmountGame4 = AllyCardAmountGame4 + ItemCardAmountGame4 + SpellCardAmountGame4;

		// Deck Ally Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally17");
		DataGameplayCards.HogwartsCardNames.Add("Ally18");
		DataGameplayCards.HogwartsCardNames.Add("Ally19");
		DataGameplayCards.HogwartsCardNames.Add("Ally20");
		DataGameplayCards.HogwartsCardNames.Add("Ally21");
		DataGameplayCards.HogwartsCardNames.Add("Ally22");
		DataGameplayCards.HogwartsCardNames.Add("Ally23");
		DataGameplayCards.HogwartsCardNames.Add("Ally24");

		// Deck Spell Cards
		DataGameplayCards.HogwartsCardNames.Add("Spl14");
		DataGameplayCards.HogwartsCardNames.Add("Spl14");
		DataGameplayCards.HogwartsCardNames.Add("Spl14");
		DataGameplayCards.HogwartsCardNames.Add("Spl15");
		DataGameplayCards.HogwartsCardNames.Add("Spl15");

		// Deck Item Cards
		DataGameplayCards.HogwartsCardNames.Add("Item19");
		DataGameplayCards.HogwartsCardNames.Add("Item20");
		DataGameplayCards.HogwartsCardNames.Add("Item21");
		DataGameplayCards.HogwartsCardNames.Add("Item21");
		DataGameplayCards.HogwartsCardNames.Add("Item21");
		DataGameplayCards.HogwartsCardNames.Add("Item21");
		DataGameplayCards.HogwartsCardNames.Add("Item21");
		DataGameplayCards.HogwartsCardNames.Add("Item21");
	}

	public void SetHogwartsGame5Data() {
		AllyCardAmountGame5 = 6;
		SpellCardAmountGame5 = 2;
		ItemCardAmountGame5 = 2;
		HogwartsCardAmountGame5 = AllyCardAmountGame5 + ItemCardAmountGame5 + SpellCardAmountGame5;

		// Deck Ally Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally25");
		DataGameplayCards.HogwartsCardNames.Add("Ally26");
		DataGameplayCards.HogwartsCardNames.Add("Ally27");
		DataGameplayCards.HogwartsCardNames.Add("Ally28");
		DataGameplayCards.HogwartsCardNames.Add("Ally29");
		DataGameplayCards.HogwartsCardNames.Add("Ally30");

		// Deck Spell Cards
		DataGameplayCards.HogwartsCardNames.Add("Spl16");
		DataGameplayCards.HogwartsCardNames.Add("Spl16");

		// Deck Item Cards
		DataGameplayCards.HogwartsCardNames.Add("Item22");
		DataGameplayCards.HogwartsCardNames.Add("Item22");
	}

	public void SetHogwartsGame6Data() {
		AllyCardAmountGame6 = 1;
		SpellCardAmountGame6 = 2;
		ItemCardAmountGame6 = 7;
		HogwartsCardAmountGame6 = AllyCardAmountGame6 + ItemCardAmountGame6 + SpellCardAmountGame6;

		// Deck Ally Cards
		DataGameplayCards.HogwartsCardNames.Add("Ally31");

		// Deck Spell Cards
		DataGameplayCards.HogwartsCardNames.Add("Spl17");
		DataGameplayCards.HogwartsCardNames.Add("Spl17");

		// Deck Item Cards
		DataGameplayCards.HogwartsCardNames.Add("Item23");
		DataGameplayCards.HogwartsCardNames.Add("Item24");
		DataGameplayCards.HogwartsCardNames.Add("Item24");
		DataGameplayCards.HogwartsCardNames.Add("Item25");
		DataGameplayCards.HogwartsCardNames.Add("Item26");
		DataGameplayCards.HogwartsCardNames.Add("Item27");
		DataGameplayCards.HogwartsCardNames.Add("Item27");
	}

	public void SetHogwartsGame7Data() {
		AllyCardAmountGame7 = 0;
		SpellCardAmountGame7 = 0;
		ItemCardAmountGame7 = 1;
		HogwartsCardAmountGame7 = AllyCardAmountGame7 + ItemCardAmountGame7 + SpellCardAmountGame7;

		// Deck Ally Cards
		// None Added

		// Deck Spell Cards
		// None Added

		// Deck Item Cards
		DataGameplayCards.HogwartsCardNames.Add("Item28");
	}

	public void SetRemainingData() {
		// Set Initial Hero Data
		if (DataGameplaySetup.HeroAmount == 4) {
			DataGameplayHeroes.BoltSizeHero1 = 0;
			DataGameplayHeroes.BoltSizeHero2 = 0;
			DataGameplayHeroes.BoltSizeHero3 = 0;
			DataGameplayHeroes.BoltSizeHero4 = 0;
			DataGameplayHeroes.CanDrawCardsHero1 = true;
			DataGameplayHeroes.CanDrawCardsHero2 = true;
			DataGameplayHeroes.CanDrawCardsHero3 = true;
			DataGameplayHeroes.CanDrawCardsHero4 = true;
			DataGameplayHeroes.CanGainBoltsHero1 = true;
			DataGameplayHeroes.CanGainBoltsHero2 = true;
			DataGameplayHeroes.CanGainBoltsHero3 = true;
			DataGameplayHeroes.CanGainBoltsHero4 = true;
			DataGameplayHeroes.CanGainCoinsHero1 = true;
			DataGameplayHeroes.CanGainCoinsHero2 = true;
			DataGameplayHeroes.CanGainCoinsHero3 = true;
			DataGameplayHeroes.CanGainCoinsHero4 = true;
			DataGameplayHeroes.CanGainHeartsHero1 = true;
			DataGameplayHeroes.CanGainHeartsHero2 = true;
			DataGameplayHeroes.CanGainHeartsHero3 = true;
			DataGameplayHeroes.CanGainHeartsHero4 = true;
			DataGameplayHeroes.CoinSizeHero1 = 0;
			DataGameplayHeroes.CoinSizeHero2 = 0;
			DataGameplayHeroes.CoinSizeHero3 = 0;
			DataGameplayHeroes.CoinSizeHero4 = 0;
			DataGameplayHeroes.DeckSizeHero1 = 5;
			DataGameplayHeroes.DeckSizeHero2 = 5;
			DataGameplayHeroes.DeckSizeHero3 = 5;
			DataGameplayHeroes.DeckSizeHero4 = 5;
			DataGameplayHeroes.HandSizeHero1 = 5;
			DataGameplayHeroes.HandSizeHero2 = 5;
			DataGameplayHeroes.HandSizeHero3 = 5;
			DataGameplayHeroes.HandSizeHero4 = 5;
			DataGameplayHeroes.DiscardSizeHero1 = 0;
			DataGameplayHeroes.DiscardSizeHero2 = 0;
			DataGameplayHeroes.DiscardSizeHero3 = 0;
			DataGameplayHeroes.DiscardSizeHero4 = 0;
			DataGameplayHeroes.HealthHero1 = 10;
			DataGameplayHeroes.HealthHero2 = 10;
			DataGameplayHeroes.HealthHero3 = 10;
			DataGameplayHeroes.HealthHero4 = 10;
			DataGameplayHeroes.RoundNumber = 1;
			DataGameplayHeroes.TurnOrderNumber = 1;
		}

		else if (DataGameplaySetup.HeroAmount == 5) {
			DataGameplayHeroes.BoltSizeHero1 = 0;
			DataGameplayHeroes.BoltSizeHero2 = 0;
			DataGameplayHeroes.BoltSizeHero3 = 0;
			DataGameplayHeroes.BoltSizeHero4 = 0;
			DataGameplayHeroes.BoltSizeHero5 = 0;
			DataGameplayHeroes.CanDrawCardsHero1 = true;
			DataGameplayHeroes.CanDrawCardsHero2 = true;
			DataGameplayHeroes.CanDrawCardsHero3 = true;
			DataGameplayHeroes.CanDrawCardsHero4 = true;
			DataGameplayHeroes.CanDrawCardsHero5 = true;
			DataGameplayHeroes.CanGainBoltsHero1 = true;
			DataGameplayHeroes.CanGainBoltsHero2 = true;
			DataGameplayHeroes.CanGainBoltsHero3 = true;
			DataGameplayHeroes.CanGainBoltsHero4 = true;
			DataGameplayHeroes.CanGainBoltsHero5 = true;
			DataGameplayHeroes.CanGainCoinsHero1 = true;
			DataGameplayHeroes.CanGainCoinsHero2 = true;
			DataGameplayHeroes.CanGainCoinsHero3 = true;
			DataGameplayHeroes.CanGainCoinsHero4 = true;
			DataGameplayHeroes.CanGainCoinsHero5 = true;
			DataGameplayHeroes.CanGainHeartsHero1 = true;
			DataGameplayHeroes.CanGainHeartsHero2 = true;
			DataGameplayHeroes.CanGainHeartsHero3 = true;
			DataGameplayHeroes.CanGainHeartsHero4 = true;
			DataGameplayHeroes.CanGainHeartsHero5 = true;
			DataGameplayHeroes.CoinSizeHero1 = 0;
			DataGameplayHeroes.CoinSizeHero2 = 0;
			DataGameplayHeroes.CoinSizeHero3 = 0;
			DataGameplayHeroes.CoinSizeHero4 = 0;
			DataGameplayHeroes.CoinSizeHero5 = 0;
			DataGameplayHeroes.DeckSizeHero1 = 5;
			DataGameplayHeroes.DeckSizeHero2 = 5;
			DataGameplayHeroes.DeckSizeHero3 = 5;
			DataGameplayHeroes.DeckSizeHero4 = 5;
			DataGameplayHeroes.DeckSizeHero5 = 5;
			DataGameplayHeroes.HandSizeHero1 = 5;
			DataGameplayHeroes.HandSizeHero2 = 5;
			DataGameplayHeroes.HandSizeHero3 = 5;
			DataGameplayHeroes.HandSizeHero4 = 5;
			DataGameplayHeroes.HandSizeHero5 = 5;
			DataGameplayHeroes.DiscardSizeHero1 = 0;
			DataGameplayHeroes.DiscardSizeHero2 = 0;
			DataGameplayHeroes.DiscardSizeHero3 = 0;
			DataGameplayHeroes.DiscardSizeHero4 = 0;
			DataGameplayHeroes.HealthHero1 = 10;
			DataGameplayHeroes.HealthHero2 = 10;
			DataGameplayHeroes.HealthHero3 = 10;
			DataGameplayHeroes.HealthHero4 = 10;
			DataGameplayHeroes.HealthHero5 = 10;
			DataGameplayHeroes.RoundNumber = 1;
			DataGameplayHeroes.TurnOrderNumber = 1;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}