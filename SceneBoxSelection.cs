using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneBoxSelection : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button BoxMainButton;
	public Button BoxMonsterButton;
	public Button BoxCharmButton;

	public Image OverlayImage;

	public Color OverlayOriginal = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	public Color OverlayAlpha = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Change Scene
	public ChangeScene Scene03LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Buttons
		Button BoxMainButtonClick = BoxMainButton.GetComponent<Button>();
		Button BoxMonsterButtonClick = BoxMonsterButton.GetComponent<Button>();
		Button BoxCharmButtonClick = BoxCharmButton.GetComponent<Button>();

		BoxMainButtonClick.onClick.AddListener(BoxMainButtonClicking);
		BoxMonsterButtonClick.onClick.AddListener(BoxMonsterButtonClicking);
		BoxCharmButtonClick.onClick.AddListener(BoxCharmButtonClicking);

		// Overlay Starting Color
		OverlayImage.GetComponent<Image>().color = OverlayOriginal;

		// Set Player Setup Data
		DataPlayerSetup.PlayerBoxNumberSelection = 0;
		DataPlayerSetup.PlayerBoxSelection = 0;
		DataPlayerSetup.PlayerCreatedRoomNumber = 0;
		DataPlayerSetup.PlayerGameTypeSelection = 0;

		// Set Game Setup Data
		DataGameplaySetup.Hero1Name = "None";
		DataGameplaySetup.Hero2Name = "None";
		DataGameplaySetup.Hero3Name = "None";
		DataGameplaySetup.Hero4Name = "None";
		DataGameplaySetup.Hero5Name = "None";
		DataGameplaySetup.HeroAmount = 0;
		DataGameplaySetup.TurnOrderHero1 = 0;
		DataGameplaySetup.TurnOrderHero2 = 0;
		DataGameplaySetup.TurnOrderHero3 = 0;
		DataGameplaySetup.TurnOrderHero4 = 0;
		DataGameplaySetup.TurnOrderHero5 = 0;

		// Play Fade Out Coroutine
		StartCoroutine(OverlayFadeOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	public IEnumerator OverlayFadeOut() {
		// Fade Overlay to Alpha
		float ElapsedTime = 0.0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime * 1.0f;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayOriginal, OverlayAlpha, ElapsedTime);
			yield return null;
		}

		// Continue With Gameplay
		OverlayImage.enabled = false;
	}

	public IEnumerator OverlayFadeIn() {
		// Fade Alpha to Overlay
		float ElapsedTime = 0.0f;
		OverlayImage.enabled = true;
		OverlayImage.GetComponent<Image>().color = OverlayAlpha;

		while (ElapsedTime < 0.5f) {
			ElapsedTime += Time.deltaTime * 1.0f;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayAlpha, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		// Load Box Number Selection Scene
		Scene03LoadRun.Scene03Load();
	}

	public void BoxMainButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxSelection = 1;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void BoxMonsterButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxSelection = 2;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void BoxCharmButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxSelection = 3;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}