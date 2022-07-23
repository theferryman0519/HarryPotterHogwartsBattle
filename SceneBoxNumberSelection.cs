using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneBoxNumberSelection : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image Box1Image;
	public Image Box2Image;
	public Image Box3Image;
	public Image Box4Image;
	public Image Box5Image;
	public Image Box6Image;
	public Image Box7Image;
	public Image BoxExtremeImage;

	public Button Box1Button;
	public Button Box2Button;
	public Button Box3Button;
	public Button Box4Button;
	public Button Box5Button;
	public Button Box6Button;
	public Button Box7Button;
	public Button BoxExtremeButton;
	public Button BackButton;

	public Image OverlayImage;

	public Color OverlayOriginal = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	public Color OverlayAlpha = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Change Scene
	public ChangeScene Scene02LoadRun;
	public ChangeScene Scene04LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Buttons
		Button Box1ButtonClick = Box1Button.GetComponent<Button>();
		Button Box2ButtonClick = Box2Button.GetComponent<Button>();
		Button Box3ButtonClick = Box3Button.GetComponent<Button>();
		Button Box4ButtonClick = Box4Button.GetComponent<Button>();
		Button Box5ButtonClick = Box5Button.GetComponent<Button>();
		Button Box6ButtonClick = Box6Button.GetComponent<Button>();
		Button Box7ButtonClick = Box7Button.GetComponent<Button>();
		Button BoxExtremeButtonClick = BoxExtremeButton.GetComponent<Button>();
		Button BackButtonClick = BackButton.GetComponent<Button>();

		Box1ButtonClick.onClick.AddListener(Box1ButtonClicking);
		Box2ButtonClick.onClick.AddListener(Box2ButtonClicking);
		Box3ButtonClick.onClick.AddListener(Box3ButtonClicking);
		Box4ButtonClick.onClick.AddListener(Box4ButtonClicking);
		Box5ButtonClick.onClick.AddListener(Box5ButtonClicking);
		Box6ButtonClick.onClick.AddListener(Box6ButtonClicking);
		Box7ButtonClick.onClick.AddListener(Box7ButtonClicking);
		BoxExtremeButtonClick.onClick.AddListener(BoxExtremeButtonClicking);
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
		ShowCertainBoxes();
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

		// Load Game Type Selection Scene
		Scene04LoadRun.Scene04Load();
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

		// Load Box Selection Scene
		Scene02LoadRun.Scene02Load();
	}

	public void Box1ButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxNumberSelection = 1;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void Box2ButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxNumberSelection = 2;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void Box3ButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxNumberSelection = 3;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void Box4ButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxNumberSelection = 4;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void Box5ButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxNumberSelection = 5;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void Box6ButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxNumberSelection = 6;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void Box7ButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxNumberSelection = 7;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void BoxExtremeButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxNumberSelection = 8;

		// Start Coroutine to Fade In Overlay
		StartCoroutine(OverlayFadeIn());
	}

	public void BackButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerBoxNumberSelection = 0;
		DataPlayerSetup.PlayerBoxSelection = 0;

		// Start Coroutine to Fade In Overlay Back
		StartCoroutine(OverlayFadeInBack());
	}

	public void ShowCertainBoxes() {
		if (DataPlayerSetup.PlayerBoxSelection == 1) {
			Box1Image.enabled = true;
			Box2Image.enabled = true;
			Box3Image.enabled = true;
			Box4Image.enabled = true;
			Box5Image.enabled = true;
			Box6Image.enabled = true;
			Box7Image.enabled = true;
			BoxExtremeImage.enabled = true;
		}

		else if (DataPlayerSetup.PlayerBoxSelection == 2) {
			Box1Image.enabled = true;
			Box2Image.enabled = true;
			Box3Image.enabled = true;
			Box4Image.enabled = true;
			Box5Image.enabled = false;
			Box6Image.enabled = false;
			Box7Image.enabled = false;
			BoxExtremeImage.enabled = true;
		}

		else if (DataPlayerSetup.PlayerBoxSelection == 3) {
			Box1Image.enabled = true;
			Box2Image.enabled = true;
			Box3Image.enabled = true;
			Box4Image.enabled = true;
			Box5Image.enabled = false;
			Box6Image.enabled = false;
			Box7Image.enabled = false;
			BoxExtremeImage.enabled = true;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}