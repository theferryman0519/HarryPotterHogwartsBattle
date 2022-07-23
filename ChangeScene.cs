using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static string Scene00 = "00FerrymanLogo";
	public static string Scene01 = "01MainLogo";
	public static string Scene02 = "02BoxSelection";
	public static string Scene03 = "03BoxNumberSelection";
	public static string Scene04 = "04GameTypeSelection";
	public static string Scene05 = "05SinglePlayerHeroSelection";
	public static string Scene06 = "06SinglePlayerGameSetup";
	public static string Scene07 = "07SinglePlayerGameplay";
	public static string Scene08 = "08SinglePlayerGameComplete";
	public static string Scene09 = "09PassPlayHeroSelection";
	public static string Scene10 = "10PassPlayGameSetup";
	public static string Scene11 = "11PassPlayGameplay";
	public static string Scene12 = "12PassPlayGameComplete";
	public static string Scene13 = "13OnlineHeroSelection";
	public static string Scene14 = "14OnlineGameSetup";
	public static string Scene15 = "15OnlineGameplay";
	public static string Scene16 = "16OnlineGameComplete";
	public static string Scene17 = "17PlayerStats";
	public static string Scene98 = "98OnlineCreateJoin";
	public static string Scene99 = "99OnlineLobby";
	
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
	// Ferryman Logo Scene
	public void Scene00Load() {
		SceneManager.LoadScene(Scene00);
	}

	// Main Logo Scene
	public void Scene01Load() {
		SceneManager.LoadScene(Scene01);
	}

	// Box Selection Scene
	public void Scene02Load() {
		SceneManager.LoadScene(Scene02);
	}

	// Box Number Selection Scene
	public void Scene03Load() {
		SceneManager.LoadScene(Scene03);
	}

	// Game Type Selection Scene
	public void Scene04Load() {
		SceneManager.LoadScene(Scene04);
	}

	// Single Player Hero Selection Scene
	public void Scene05Load() {
		SceneManager.LoadScene(Scene05);
	}

	// Single Player Game Setup Scene
	public void Scene06Load() {
		SceneManager.LoadScene(Scene06);
	}

	// Single Player Gameplay Scene
	public void Scene07Load() {
		SceneManager.LoadScene(Scene07);
	}

	// Single Player Game Complete Scene
	public void Scene08Load() {
		SceneManager.LoadScene(Scene08);
	}

	// Pass & Play Hero Selection Scene
	public void Scene09Load() {
		SceneManager.LoadScene(Scene09);
	}

	// Pass & Play Game Setup Scene
	public void Scene10Load() {
		SceneManager.LoadScene(Scene10);
	}

	// Pass & Play Gameplay Scene
	public void Scene11Load() {
		SceneManager.LoadScene(Scene11);
	}

	// Pass & Play Game Complete Scene
	public void Scene12Load() {
		SceneManager.LoadScene(Scene12);
	}

	// Online Hero Selection Scene
	public void Scene13Load() {
		SceneManager.LoadScene(Scene13);
	}

	// Online Game Setup Scene
	public void Scene14Load() {
		SceneManager.LoadScene(Scene14);
	}

	// Online Gameplay Scene
	public void Scene15Load() {
		SceneManager.LoadScene(Scene15);
	}

	// Online Game Complete Scene
	public void Scene16Load() {
		SceneManager.LoadScene(Scene16);
	}

	// Player Stats Scene
	public void Scene17Load() {
		SceneManager.LoadScene(Scene17);
	}

	// Online Create or Join Scene
	public void Scene98Load() {
		SceneManager.LoadScene(Scene98);
	}

	// Online Lobby Scene
	public void Scene99Load() {
		SceneManager.LoadScene(Scene99);
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}