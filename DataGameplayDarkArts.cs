using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class DataGameplayDarkArts : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
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
	public void EffectDarkArts01() {
		// Active Hero Lose 2 Hearts
		if (DataGameplayHeroes.TurnOrderNumber == 1) {
			DataGameplayHeroes.HealthHero1 = DataGameplayHeroes.HealthHero1 - 2;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 2) {
			DataGameplayHeroes.HealthHero2 = DataGameplayHeroes.HealthHero2 - 2;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 3) {
			DataGameplayHeroes.HealthHero3 = DataGameplayHeroes.HealthHero3 - 2;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 4) {
			DataGameplayHeroes.HealthHero4 = DataGameplayHeroes.HealthHero4 - 2;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 5) {
			DataGameplayHeroes.HealthHero5 = DataGameplayHeroes.HealthHero5 - 2;
		}
	}

	public void EffectDarkArts02() {
		// All Heroes Lose 1 Heart
		DataGameplayHeroes.HealthHero1 = DataGameplayHeroes.HealthHero1 - 1;
		DataGameplayHeroes.HealthHero2 = DataGameplayHeroes.HealthHero2 - 1;
		DataGameplayHeroes.HealthHero3 = DataGameplayHeroes.HealthHero3 - 1;
		DataGameplayHeroes.HealthHero4 = DataGameplayHeroes.HealthHero4 - 1;
		DataGameplayHeroes.HealthHero5 = DataGameplayHeroes.HealthHero5 - 1;

		// All Heroes Cannot Draw Cards This Turn
		DataGameplayHeroes.CanDrawCardsHero1 = false;
		DataGameplayHeroes.CanDrawCardsHero2 = false;
		DataGameplayHeroes.CanDrawCardsHero3 = false;
		DataGameplayHeroes.CanDrawCardsHero4 = false;
		DataGameplayHeroes.CanDrawCardsHero5 = false;
	}

	public void EffectDarkArts03() {
		// Active Hero Lose 1 Heart
		if (DataGameplayHeroes.TurnOrderNumber == 1) {
			DataGameplayHeroes.HealthHero1 = DataGameplayHeroes.HealthHero1 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 2) {
			DataGameplayHeroes.HealthHero2 = DataGameplayHeroes.HealthHero2 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 3) {
			DataGameplayHeroes.HealthHero3 = DataGameplayHeroes.HealthHero3 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 4) {
			DataGameplayHeroes.HealthHero4 = DataGameplayHeroes.HealthHero4 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 5) {
			DataGameplayHeroes.HealthHero5 = DataGameplayHeroes.HealthHero5 - 1;
		}

		// Active Hero Discard 1 Card
	}

	public void EffectDarkArts04() {
		// Add 1 Location Marker
		DataGameplayCards.LocationCurrentMarkerAmount = DataGameplayCards.LocationCurrentMarkerAmount + 1;
	}

	public void EffectDarkArts05() {
		// Active Hero Lose 1 Heart
		if (DataGameplayHeroes.TurnOrderNumber == 1) {
			DataGameplayHeroes.HealthHero1 = DataGameplayHeroes.HealthHero1 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 2) {
			DataGameplayHeroes.HealthHero2 = DataGameplayHeroes.HealthHero2 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 3) {
			DataGameplayHeroes.HealthHero3 = DataGameplayHeroes.HealthHero3 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 4) {
			DataGameplayHeroes.HealthHero4 = DataGameplayHeroes.HealthHero4 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 5) {
			DataGameplayHeroes.HealthHero5 = DataGameplayHeroes.HealthHero5 - 1;
		}

		// Add 1 Location Marker
		DataGameplayCards.LocationCurrentMarkerAmount = DataGameplayCards.LocationCurrentMarkerAmount + 1;
	}

	public void EffectDarkArts06() {
		// All Choose
		// Lose 1 Item
		// Lose 2 Hearts
	}

	public void EffectDarkArts07() {
		// All Choose
		// Lose 1 Spell
		// Lose 2 Hearts
	}

	public void EffectDarkArts08() {
		// All Choose
		// Lose 1 Ally
		// Lose 2 Hearts
	}

	public void EffectDarkArts09() {
		// All Reveal Top Card In Deck
		// Check Coin Value Of Revealed Card
		// If Coin Value 1 Or More, Discard Card
		// If Coin Value 1 Or More, Lose 2 Hearts
	}

	public void EffectDarkArts10() {
		// Active Hero Lose 1 Heart
		if (DataGameplayHeroes.TurnOrderNumber == 1) {
			DataGameplayHeroes.HealthHero1 = DataGameplayHeroes.HealthHero1 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 2) {
			DataGameplayHeroes.HealthHero2 = DataGameplayHeroes.HealthHero2 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 3) {
			DataGameplayHeroes.HealthHero3 = DataGameplayHeroes.HealthHero3 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 4) {
			DataGameplayHeroes.HealthHero4 = DataGameplayHeroes.HealthHero4 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 5) {
			DataGameplayHeroes.HealthHero5 = DataGameplayHeroes.HealthHero5 - 1;
		}

		// Active Hero Cannot Assign 2 Or More Bolts Per Villain This Turn
	}

	public void EffectDarkArts11() {
		// Active Hero Lose 1 Heart
		if (DataGameplayHeroes.TurnOrderNumber == 1) {
			DataGameplayHeroes.HealthHero1 = DataGameplayHeroes.HealthHero1 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 2) {
			DataGameplayHeroes.HealthHero2 = DataGameplayHeroes.HealthHero2 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 3) {
			DataGameplayHeroes.HealthHero3 = DataGameplayHeroes.HealthHero3 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 4) {
			DataGameplayHeroes.HealthHero4 = DataGameplayHeroes.HealthHero4 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 5) {
			DataGameplayHeroes.HealthHero5 = DataGameplayHeroes.HealthHero5 - 1;
		}

		// All Heroes Lose 1 Heart
		DataGameplayHeroes.HealthHero1 = DataGameplayHeroes.HealthHero1 - 1;
		DataGameplayHeroes.HealthHero2 = DataGameplayHeroes.HealthHero2 - 1;
		DataGameplayHeroes.HealthHero3 = DataGameplayHeroes.HealthHero3 - 1;
		DataGameplayHeroes.HealthHero4 = DataGameplayHeroes.HealthHero4 - 1;
		DataGameplayHeroes.HealthHero5 = DataGameplayHeroes.HealthHero5 - 1;
	}

	public void EffectDarkArts12() {
		// Active Hero Lose 1 Heart
		if (DataGameplayHeroes.TurnOrderNumber == 1) {
			DataGameplayHeroes.HealthHero1 = DataGameplayHeroes.HealthHero1 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 2) {
			DataGameplayHeroes.HealthHero2 = DataGameplayHeroes.HealthHero2 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 3) {
			DataGameplayHeroes.HealthHero3 = DataGameplayHeroes.HealthHero3 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 4) {
			DataGameplayHeroes.HealthHero4 = DataGameplayHeroes.HealthHero4 - 1;
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 5) {
			DataGameplayHeroes.HealthHero5 = DataGameplayHeroes.HealthHero5 - 1;
		}

		// Draw Additional Dark Arts Card
		DataGameplayCards.DarkArtsDrawAmount = DataGameplayCards.DarkArtsDrawAmount + 1;
	}

	public void EffectDarkArts13() {}

	public void EffectDarkArts14() {}

	public void EffectDarkArts15() {}

	public void EffectDarkArts16() {}

	public void EffectDarkArts17() {}

	public void EffectDarkArts18() {}

	public void EffectDarkArts19() {}

	public void EffectDarkArts20() {}

	public void EffectDarkArts21() {}

	public void EffectDarkArts22() {}

	public void EffectDarkArts23() {}

	public void EffectDarkArts24() {}

	public void EffectDarkArts25() {}

	public void EffectDarkArts26() {}

	public void EffectDarkArts27() {}

	public void EffectDarkArts28() {}

	public void EffectDarkArts29() {}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}