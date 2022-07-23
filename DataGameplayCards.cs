using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class DataGameplayCards : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// Location Cards
	public static int LocationCardAmount;
	public static int LocationCurrentCardAmount;
	public static List<string> LocationCardNames = new List<string>();
	public static string LocationActiveCard;
	public static int LocationMarkerAmount;
	public static int LocationCurrentMarkerAmount;

	// Dark Arts Cards
	public static int DarkArtsCardAmount;
	public static int DarkArtsDeckAmount;
	public static int DarkArtsDiscardAmount;
	public static List<string> DarkArtsCardNames = new List<string>();
	public static List<string> DarkArtsCardDiscardNames = new List<string>();
	public static string DarkArtsActiveCard;
	public static int DarkArtsDrawAmount;
	public static int DarkArtsCurrentDrawAmount;
	public static int DarkArtsRandomCardNumber;

	// Villain Cards
	public static int VillainCardAmount;
	public static List<string> VillainCardNames = new List<string>();
	public static bool VillainSlot1Used;
	public static bool VillainSlot2Used;
	public static bool VillainSlot3Used;
	public static bool VillainSlot4Used;
	public static bool Villain4Revealed;
	public static string VillainName1;
	public static string VillainName2;
	public static string VillainName3;
	public static string VillainName4;
	public static int VillainBoltAmount1;
	public static int VillainBoltAmount2;
	public static int VillainBoltAmount3;
	public static int VillainBoltAmount4;
	public static int VillainCoinAmount1;
	public static int VillainCoinAmount2;
	public static int VillainCoinAmount3;
	public static int VillainCoinAmount4;
	public static string VillainCreature1;
	public static string VillainCreature2;
	public static string VillainCreature3;
	public static string VillainCreature4;
	public static bool VillainStunned1;
	public static bool VillainStunned2;
	public static bool VillainStunned3;
	public static bool VillainStunned4;
	public static int VillainStunnedCurrentTurn1;
	public static int VillainStunnedCurrentTurn2;
	public static int VillainStunnedCurrentTurn3;
	public static int VillainStunnedCurrentTurn4;
	public static int VillainStunnedEndTurn1;
	public static int VillainStunnedEndTurn2;
	public static int VillainStunnedEndTurn3;
	public static int VillainStunnedEndTurn4;
	public static bool VillainEffectComplete1;
	public static bool VillainEffectComplete2;
	public static bool VillainEffectComplete3;
	public static bool VillainEffectComplete4;
	public static bool VillainDefeated1;
	public static bool VillainDefeated2;
	public static bool VillainDefeated3;
	public static bool VillainDefeated4;
	public static bool VillainRewardComplete1;
	public static bool VillainRewardComplete2;
	public static bool VillainRewardComplete3;
	public static bool VillainRewardComplete4;


	// Hogwarts Cards
	public static int HogwartsCardAmount;
	public static List<string> HogwartsCardNames = new List<string>();

	// Horcrux Cards
	public static int HorcruxCardAmount;
	public static List<string> HorcruxCardNames = new List<string>();

	// Proficiency Cards
	public static int ProficiencyCardAmount;
	public static List<string> ProficiencyCardNames = new List<string>();

	// Ability Cards
	public static int AbilityCardAmount;
	public static List<string> AbilityCardNames = new List<string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Dark Arts Cards
	public DataGameplayDarkArts EffectDarkArts01Run;
	public DataGameplayDarkArts EffectDarkArts02Run;
	public DataGameplayDarkArts EffectDarkArts03Run;
	public DataGameplayDarkArts EffectDarkArts04Run;
	public DataGameplayDarkArts EffectDarkArts05Run;
	public DataGameplayDarkArts EffectDarkArts06Run;
	public DataGameplayDarkArts EffectDarkArts07Run;
	public DataGameplayDarkArts EffectDarkArts08Run;
	public DataGameplayDarkArts EffectDarkArts09Run;
	public DataGameplayDarkArts EffectDarkArts10Run;
	public DataGameplayDarkArts EffectDarkArts11Run;
	public DataGameplayDarkArts EffectDarkArts12Run;
	public DataGameplayDarkArts EffectDarkArts13Run;
	public DataGameplayDarkArts EffectDarkArts14Run;
	public DataGameplayDarkArts EffectDarkArts15Run;
	public DataGameplayDarkArts EffectDarkArts16Run;
	public DataGameplayDarkArts EffectDarkArts17Run;
	public DataGameplayDarkArts EffectDarkArts18Run;
	public DataGameplayDarkArts EffectDarkArts19Run;
	public DataGameplayDarkArts EffectDarkArts20Run;
	public DataGameplayDarkArts EffectDarkArts21Run;
	public DataGameplayDarkArts EffectDarkArts22Run;
	public DataGameplayDarkArts EffectDarkArts23Run;
	public DataGameplayDarkArts EffectDarkArts24Run;
	public DataGameplayDarkArts EffectDarkArts25Run;
	public DataGameplayDarkArts EffectDarkArts26Run;
	public DataGameplayDarkArts EffectDarkArts27Run;
	public DataGameplayDarkArts EffectDarkArts28Run;
	public DataGameplayDarkArts EffectDarkArts29Run;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	// Location Cards
	public void DetermineMarkerAmount() {
		// Loc01
		if (LocationActiveCard == "Loc01") {
			LocationMarkerAmount = 4;
			DarkArtsDrawAmount = 1;
		}

		// Loc02
		else if (LocationActiveCard == "Loc02") {
			LocationMarkerAmount = 4;
			DarkArtsDrawAmount = 1;
		}

		// Loc03
		else if (LocationActiveCard == "Loc03") {
			LocationMarkerAmount = 4;
			DarkArtsDrawAmount = 1;
		}

		// Loc04
		else if (LocationActiveCard == "Loc04") {
			LocationMarkerAmount = 4;
			DarkArtsDrawAmount = 1;
		}

		// Loc05
		else if (LocationActiveCard == "Loc05") {
			LocationMarkerAmount = 5;
			DarkArtsDrawAmount = 2;
		}

		// Loc06
		else if (LocationActiveCard == "Loc06") {
			LocationMarkerAmount = 5;
			DarkArtsDrawAmount = 1;
		}

		// Loc07
		else if (LocationActiveCard == "Loc07") {
			LocationMarkerAmount = 6;
			DarkArtsDrawAmount = 2;
		}

		// Loc08
		else if (LocationActiveCard == "Loc08") {
			LocationMarkerAmount = 6;
			DarkArtsDrawAmount = 2;
		}

		// Loc09
		else if (LocationActiveCard == "Loc09") {
			LocationMarkerAmount = 6;
			DarkArtsDrawAmount = 1;
		}

		// Loc10
		else if (LocationActiveCard == "Loc10") {
			LocationMarkerAmount = 6;
			DarkArtsDrawAmount = 2;
		}

		// Loc11
		else if (LocationActiveCard == "Loc11") {
			LocationMarkerAmount = 7;
			DarkArtsDrawAmount = 2;
		}

		// Loc12
		else if (LocationActiveCard == "Loc12") {
			LocationMarkerAmount = 7;
			DarkArtsDrawAmount = 1;
		}

		// Loc13
		else if (LocationActiveCard == "Loc13") {
			LocationMarkerAmount = 7;
			DarkArtsDrawAmount = 2;
		}

		// Loc14
		else if (LocationActiveCard == "Loc14") {
			LocationMarkerAmount = 7;
			DarkArtsDrawAmount = 2;
		}

		// Loc15
		else if (LocationActiveCard == "Loc15") {
			LocationMarkerAmount = 7;
			DarkArtsDrawAmount = 1;
		}

		// Loc16
		else if (LocationActiveCard == "Loc16") {
			LocationMarkerAmount = 7;
			DarkArtsDrawAmount = 2;
		}

		// Loc17
		else if (LocationActiveCard == "Loc17") {
			LocationMarkerAmount = 8;
			DarkArtsDrawAmount = 3;
		}

		// Loc18
		else if (LocationActiveCard == "Loc18") {
			LocationMarkerAmount = 6;
			DarkArtsDrawAmount = 1;
		}

		// Loc19
		else if (LocationActiveCard == "Loc19") {
			LocationMarkerAmount = 6;
			DarkArtsDrawAmount = 2;
		}

		// Loc20
		else if (LocationActiveCard == "Loc20") {
			LocationMarkerAmount = 7;
			DarkArtsDrawAmount = 2;
		}

		// Loc21
		else if (LocationActiveCard == "Loc21") {
			LocationMarkerAmount = 8;
			DarkArtsDrawAmount = 3;
		}
	}

	// Dark Arts Cards
	public void DetermineDarkArtsDrawAmount() {
		// Determine Bellatrix
		if ((VillainName1 == "Vill14") || (VillainName2 == "Vill14") || (VillainName3 == "Vill14")) {
			DarkArtsDrawAmount = DarkArtsDrawAmount + 1;
		}

		// Reset Current Draw Amount
		DarkArtsCurrentDrawAmount = 0;
	}

	public void DrawDarkArtsCard() {
		// Randomize Draw Number
		DarkArtsRandomCardNumber = Random.Range(0, DarkArtsCardNames.Count);

		// Increase Draw Amount
		DarkArtsCurrentDrawAmount = DarkArtsCurrentDrawAmount + 1

		// Determine Draw Name
		DarkArtsActiveCard = DarkArtsCardNames[DarkArtsRandomCardNumber];

		// Determine Dark Arts Action
		if (DarkArtsActiveCard == "Dark01") {
			EffectDarkArts01Run.EffectDarkArts01();
		}

		else if (DarkArtsActiveCard == "Dark02") {
			EffectDarkArts02Run.EffectDarkArts02();
		}

		else if (DarkArtsActiveCard == "Dark03") {
			EffectDarkArts03Run.EffectDarkArts03();
		}

		else if (DarkArtsActiveCard == "Dark04") {
			EffectDarkArts04Run.EffectDarkArts04();
		}

		else if (DarkArtsActiveCard == "Dark05") {
			EffectDarkArts05Run.EffectDarkArts05();
		}

		else if (DarkArtsActiveCard == "Dark06") {
			EffectDarkArts06Run.EffectDarkArts06();
		}

		else if (DarkArtsActiveCard == "Dark07") {
			EffectDarkArts07Run.EffectDarkArts07();
		}

		else if (DarkArtsActiveCard == "Dark08") {
			EffectDarkArts08Run.EffectDarkArts08();
		}

		else if (DarkArtsActiveCard == "Dark09") {
			EffectDarkArts09Run.EffectDarkArts09();
		}

		else if (DarkArtsActiveCard == "Dark10") {
			EffectDarkArts10Run.EffectDarkArts10();
		}

		else if (DarkArtsActiveCard == "Dark11") {
			EffectDarkArts11Run.EffectDarkArts11();
		}

		else if (DarkArtsActiveCard == "Dark12") {
			EffectDarkArts12Run.EffectDarkArts12();
		}

		else if (DarkArtsActiveCard == "Dark13") {
			EffectDarkArts13Run.EffectDarkArts13();
		}

		else if (DarkArtsActiveCard == "Dark14") {
			EffectDarkArts14Run.EffectDarkArts14();
		}

		else if (DarkArtsActiveCard == "Dark15") {
			EffectDarkArts15Run.EffectDarkArts15();
		}

		else if (DarkArtsActiveCard == "Dark16") {
			EffectDarkArts16Run.EffectDarkArts16();
		}

		else if (DarkArtsActiveCard == "Dark17") {
			EffectDarkArts17Run.EffectDarkArts17();
		}

		else if (DarkArtsActiveCard == "Dark18") {
			EffectDarkArts18Run.EffectDarkArts18();
		}

		else if (DarkArtsActiveCard == "Dark19") {
			EffectDarkArts19Run.EffectDarkArts19();
		}

		else if (DarkArtsActiveCard == "Dark20") {
			EffectDarkArts20Run.EffectDarkArts20();
		}

		else if (DarkArtsActiveCard == "Dark21") {
			EffectDarkArts21Run.EffectDarkArts21();
		}

		else if (DarkArtsActiveCard == "Dark22") {
			EffectDarkArts22Run.EffectDarkArts22();
		}

		else if (DarkArtsActiveCard == "Dark23") {
			EffectDarkArts23Run.EffectDarkArts23();
		}

		else if (DarkArtsActiveCard == "Dark24") {
			EffectDarkArts24Run.EffectDarkArts24();
		}

		else if (DarkArtsActiveCard == "Dark25") {
			EffectDarkArts25Run.EffectDarkArts25();
		}

		else if (DarkArtsActiveCard == "Dark26") {
			EffectDarkArts26Run.EffectDarkArts26();
		}

		else if (DarkArtsActiveCard == "Dark27") {
			EffectDarkArts27Run.EffectDarkArts27();
		}

		else if (DarkArtsActiveCard == "Dark28") {
			EffectDarkArts28Run.EffectDarkArts28();
		}

		else if (DarkArtsActiveCard == "Dark29") {
			EffectDarkArts29Run.EffectDarkArts29();
		}

		// Check If Heroes Stunned
		// Discard Dark Arts Card
		// Recalculate Dark Arts Draw Amount
	}

	// Villain Cards
	public void DetermineVillainStats() {
		// Villain Slot 1
		// Vill01
		if (VillainName1 == "Vill01") {
			VillainBoltAmount1 = 6;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill02
		else if (VillainName1 == "Vill02") {
			VillainBoltAmount1 = 6;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill03
		else if (VillainName1 == "Vill03") {
			VillainBoltAmount1 = 5;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill04
		else if (VillainName1 == "Vill04") {
			VillainBoltAmount1 = 6;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill05
		else if (VillainName1 == "Vill05") {
			VillainBoltAmount1 = 7;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill06
		else if (VillainName1 == "Vill06") {
			VillainBoltAmount1 = 8;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill07
		else if (VillainName1 == "Vill07") {
			VillainBoltAmount1 = 7;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill08
		else if (VillainName1 == "Vill08") {
			VillainBoltAmount1 = 8;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill09
		else if (VillainName1 == "Vill09") {
			VillainBoltAmount1 = 7;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill10
		else if (VillainName1 == "Vill10") {
			VillainBoltAmount1 = 7;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill12
		else if (VillainName1 == "Vill12") {
			VillainBoltAmount1 = 7;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill13
		else if (VillainName1 == "Vill13") {
			VillainBoltAmount1 = 7;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill14
		else if (VillainName1 == "Vill14") {
			VillainBoltAmount1 = 9;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Vill16
		else if (VillainName1 == "Vill16") {
			VillainBoltAmount1 = 8;
			VillainCoinAmount1 = 0;
			VillainCreature1 = "Villain";
		}

		// Villain Slot 2
		// Vill01
		if (VillainName2 == "Vill01") {
			VillainBoltAmount2 = 6;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill02
		else if (VillainName2 == "Vill02") {
			VillainBoltAmount2 = 6;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill03
		else if (VillainName2 == "Vill03") {
			VillainBoltAmount2 = 5;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill04
		else if (VillainName2 == "Vill04") {
			VillainBoltAmount2 = 6;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill05
		else if (VillainName2 == "Vill05") {
			VillainBoltAmount2 = 7;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill06
		else if (VillainName2 == "Vill06") {
			VillainBoltAmount2 = 8;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill07
		else if (VillainName2 == "Vill07") {
			VillainBoltAmount2 = 7;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill08
		else if (VillainName2 == "Vill08") {
			VillainBoltAmount2 = 8;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill09
		else if (VillainName2 == "Vill09") {
			VillainBoltAmount2 = 7;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill10
		else if (VillainName2 == "Vill10") {
			VillainBoltAmount2 = 7;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill12
		else if (VillainName2 == "Vill12") {
			VillainBoltAmount2 = 7;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill13
		else if (VillainName2 == "Vill13") {
			VillainBoltAmount2 = 7;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill14
		else if (VillainName2 == "Vill14") {
			VillainBoltAmount2 = 9;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Vill16
		else if (VillainName2 == "Vill16") {
			VillainBoltAmount2 = 8;
			VillainCoinAmount2 = 0;
			VillainCreature2 = "Villain";
		}

		// Villain Slot 3
		// Vill01
		if (VillainName3 == "Vill01") {
			VillainBoltAmount3 = 6;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill02
		else if (VillainName3 == "Vill02") {
			VillainBoltAmount3 = 6;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill03
		else if (VillainName3 == "Vill03") {
			VillainBoltAmount3 = 5;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill04
		else if (VillainName3 == "Vill04") {
			VillainBoltAmount3 = 6;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill05
		else if (VillainName3 == "Vill05") {
			VillainBoltAmount3 = 7;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill06
		else if (VillainName3 == "Vill06") {
			VillainBoltAmount3 = 8;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill07
		else if (VillainName3 == "Vill07") {
			VillainBoltAmount3 = 7;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill08
		else if (VillainName3 == "Vill08") {
			VillainBoltAmount3 = 8;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill09
		else if (VillainName3 == "Vill09") {
			VillainBoltAmount3 = 7;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill10
		else if (VillainName3 == "Vill10") {
			VillainBoltAmount3 = 7;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill12
		else if (VillainName3 == "Vill12") {
			VillainBoltAmount3 = 7;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill13
		else if (VillainName3 == "Vill13") {
			VillainBoltAmount3 = 7;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill14
		else if (VillainName3 == "Vill14") {
			VillainBoltAmount3 = 9;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Vill16
		else if (VillainName3 == "Vill16") {
			VillainBoltAmount3 = 8;
			VillainCoinAmount3 = 0;
			VillainCreature3 = "Villain";
		}

		// Villain Slot 4
		// Vill11
		if (VillainName4 == "Vill11") {
			VillainBoltAmount4 = 10;
			VillainCoinAmount4 = 0;
			VillainCreature4 = "Villain";
		}

		// Vill15
		else if (VillainName4 == "Vill15") {
			VillainBoltAmount4 = 15;
			VillainCoinAmount4 = 0;
			VillainCreature4 = "Villain";
		}

		// Vill17
		else if (VillainName4 == "Vill17") {
			VillainBoltAmount4 = 20;
			VillainCoinAmount4 = 0;
			VillainCreature4 = "Villain";
		}
	}

	public void DetermineVillainStunned() {
		// Villain Slot 1
		if (VillainStunned1 == true) {
			if (VillainStunnedCurrentTurn1 == VillainStunnedEndTurn1) {
				VillainStunned1 = false;
				VillainEffectComplete1 = false;
			}

			else {
				VillainStunned1 = true;
				VillainEffectComplete1 = true;
			}
		}

		else {
			VillainEffectComplete1 = false;
		}

		// Villain Slot 2
		if (VillainSlot2Used == true) {
			if (VillainStunned2 == true) {
				if (VillainStunnedCurrentTurn2 == VillainStunnedEndTurn2) {
					VillainStunned2 = false;
					VillainEffectComplete2 = false;
				}

				else {
					VillainStunned2 = true;
					VillainEffectComplete2 = true;
				}
			}

			else {
				VillainEffectComplete2 = false;
			}
		}

		// Villain Slot 3
		if (VillainSlot3Used == true) {
			if (VillainStunned3 == true) {
				if (VillainStunnedCurrentTurn3 == VillainStunnedEndTurn3) {
					VillainStunned3 = false;
					VillainEffectComplete3 = false;
				}

				else {
					VillainStunned3 = true;
					VillainEffectComplete3 = true;
				}
			}

			else {
				VillainEffectComplete3 = false;
			}
		}

		// Villain Slot 4
		if (VillainSlot4Used == true) {
			if (Villain4Revealed == true) {
				if (VillainStunned4 == true) {
					if (VillainStunnedCurrentTurn4 == VillainStunnedEndTurn4) {
						VillainStunned4 = false;
						VillainEffectComplete4 = false;
					}

					else {
						VillainStunned4 = true;
						VillainEffectComplete4 = true;
					}
				}

				else {
					VillainEffectComplete4 = false;
				}
			}
		}
	}

	// Hogwarts Cards
	// Horcrux Cards
	// Proficiency Cards
	// Ability Cards
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}