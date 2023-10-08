// Main Dependencies
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Game Dependencies

namespace CardDataSpace {
public class CardData_Controller : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static CardData_Controller Instance {
		get {
			return CardDataControllerInstance;
		}
	}
	
	private static CardData_Controller CardDataControllerInstance = null;
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		if ((CardDataControllerInstance != null) && (CardDataControllerInstance != this)) {
			Destroy(this.gameObject);
			return;
		}
		
		else {
			CardDataControllerInstance = this;
		}
		
		DontDestroyOnLoad(this.gameObject);
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: ENUMERATOR FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: ENUMERATOR FUNCTIONS ----------------------------------------
// ---------------------------------------- START: VOID FUNCTIONS ----------------------------------------
	
	
// ---------------------------------------- END: VOID FUNCTIONS ----------------------------------------
}}