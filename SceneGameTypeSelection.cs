using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneGameTypeSelection : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button SingleButton;
	public Button PassPlayButton;
	public Button OnlineButton;
	public Button BackButton;

	public Image OverlayImage;

	public Color OverlayOriginal = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	public Color OverlayAlpha = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Change Scene
	public ChangeScene Scene03LoadRun;
	public ChangeScene Scene05LoadRun;
	public ChangeScene Scene09LoadRun;
	public ChangeScene Scene98LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Buttons
		Button SingleButtonClick = SingleButton.GetComponent<Button>();
		Button PassPlayButtonClick = PassPlayButton.GetComponent<Button>();
		Button OnlineButtonClick = OnlineButton.GetComponent<Button>();
		Button BackButtonClick = BackButton.GetComponent<Button>();

		SingleButtonClick.onClick.AddListener(SingleButtonClicking);
		PassPlayButtonClick.onClick.AddListener(PassPlayButtonClicking);
		OnlineButtonClick.onClick.AddListener(OnlineButtonClicking);
		BackButtonClick.onClick.AddListener(BackButtonClicking);

		// Overlay Starting Color
		OverlayImage.GetComponent<Image>().color = OverlayOriginal;

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

		while (ElapsedTime < 0.5f) {
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

		if (DataPlayerSetup.PlayerGameTypeSelection == 1) {
			// Load Single Hero Selection Scene
			Scene05LoadRun.Scene05Load();
		}

		else if (DataPlayerSetup.PlayerGameTypeSelection == 2) {
			// Load Pass & Play Hero Selection Scene
			Scene09LoadRun.Scene09Load();
		}

		else if (DataPlayerSetup.PlayerGameTypeSelection == 3) {
			// Load Online Create or Join Scene
			Scene98LoadRun.Scene98Load();
		}
	}

	public IEnumerator OverlayFadeInBack() {
		// Fade Alpha to Overlay
		float ElapsedTime = 0.0f;
		OverlayImage.enabled = true;
		OverlayImage.GetComponent<Image>().color = OverlayAlpha;

		while (ElapsedTime < 0.5f) {
			ElapsedTime += Time.deltaTime * 1.0f;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayAlpha, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		// Load Single Hero Selection Scene
		Scene03LoadRun.Scene03Load();
	}

	public void SingleButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerGameTypeSelection = 1;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void PassPlayButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerGameTypeSelection = 2;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void OnlineButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerGameTypeSelection = 3;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void BackButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerGameTypeSelection = 0;
		DataPlayerSetup.PlayerBoxNumberSelection = 0;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeInBack());
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}