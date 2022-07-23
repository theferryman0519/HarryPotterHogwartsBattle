using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ScenePassPlayHeroSelection : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Button PlayerAmount4Button;
	public Button PlayerAmount5Button;
	public Button HeroSelectHarryButton;
	public Button HeroSelectHermioneButton;
	public Button HeroSelectRonButton;
	public Button HeroSelectNevilleButton;
	public Button HeroSelectLunaButton;
	public Button HeroSelectGinnyButton;
	public Button ReselectButton;
	public Button ContinueButton;
	public Button BackButton;

	public Image PlayerAmount4Image;
	public Image PlayerAmount5Image;
	public Image HeroSelectHarryImage;
	public Image HeroSelectHermioneImage;
	public Image HeroSelectRonImage;
	public Image HeroSelectNevilleImage;
	public Image HeroSelectLunaImage;
	public Image HeroSelectGinnyImage;
	public Image ReselectImage;
	public Image ContinueImage;

	public Sprite HeroSelectHarrySprite;
	public Sprite HeroSelectHermioneSprite;
	public Sprite HeroSelectRonSprite;
	public Sprite HeroSelectNevilleSprite;
	public Sprite HeroSelectLunaSprite;
	public Sprite HeroSelectGinnySprite;
	public Sprite HeroSelectPlayerChosen1;
	public Sprite HeroSelectPlayerChosen2;
	public Sprite HeroSelectPlayerChosen3;
	public Sprite HeroSelectPlayerChosen4;
	public Sprite HeroSelectPlayerChosen5;

	public Image OverlayImage;

	public Color OverlayOriginal = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	public Color OverlayAlpha = new Color(1.0f, 1.0f, 1.0f, 0.0f);

	public int PlayerSelectionTurn;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	// Change Scene
	public ChangeScene Scene04LoadRun;
	public ChangeScene Scene10LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Buttons
		Button PlayerAmount4ButtonClick = PlayerAmount4Button.GetComponent<Button>();
		Button PlayerAmount5ButtonClick = PlayerAmount5Button.GetComponent<Button>();
		Button HeroSelectHarryButtonClick = HeroSelectHarryButton.GetComponent<Button>();
		Button HeroSelectHermioneButtonClick = HeroSelectHermioneButton.GetComponent<Button>();
		Button HeroSelectRonButtonClick = HeroSelectRonButton.GetComponent<Button>();
		Button HeroSelectNevilleButtonClick = HeroSelectNevilleButton.GetComponent<Button>();
		Button HeroSelectLunaButtonClick = HeroSelectLunaButton.GetComponent<Button>();
		Button HeroSelectGinnyButtonClick = HeroSelectGinnyButton.GetComponent<Button>();
		Button ReselectButtonClick = ReselectButton.GetComponent<Button>();
		Button ContinueButtonClick = ContinueButton.GetComponent<Button>();
		Button BackButtonClick = BackButton.GetComponent<Button>();

		PlayerAmount4ButtonClick.onClick.AddListener(PlayerAmount4ButtonClicking);
		PlayerAmount5ButtonClick.onClick.AddListener(PlayerAmount5ButtonClicking);
		HeroSelectHarryButtonClick.onClick.AddListener(HeroSelectHarryButtonClicking);
		HeroSelectHermioneButtonClick.onClick.AddListener(HeroSelectHermioneButtonClicking);
		HeroSelectRonButtonClick.onClick.AddListener(HeroSelectRonButtonClicking);
		HeroSelectNevilleButtonClick.onClick.AddListener(HeroSelectNevilleButtonClicking);
		HeroSelectLunaButtonClick.onClick.AddListener(HeroSelectLunaButtonClicking);
		HeroSelectGinnyButtonClick.onClick.AddListener(HeroSelectGinnyButtonClicking);
		ReselectButtonClick.onClick.AddListener(ReselectButtonClicking);
		ContinueButtonClick.onClick.AddListener(ContinueButtonClicking);
		BackButtonClick.onClick.AddListener(BackButtonClicking);
		
		// Overlay Starting Color
		OverlayImage.GetComponent<Image>().color = OverlayOriginal;

		// Disable All Hero Buttons
		HeroSelectHarryImage.enabled = false;
		HeroSelectHermioneImage.enabled = false;
		HeroSelectRonImage.enabled = false;
		HeroSelectNevilleImage.enabled = false;
		HeroSelectLunaImage.enabled = false;
		HeroSelectGinnyImage.enabled = false;
		ReselectImage.enabled = false;

		// Disable Continue Button
		ContinueImage.enabled = false;

		// Display Hero Original Sprites
		HeroSelectHarryImage.sprite = HeroSelectHarrySprite;
		HeroSelectHermioneImage.sprite = HeroSelectHermioneSprite;
		HeroSelectRonImage.sprite = HeroSelectRonSprite;
		HeroSelectNevilleImage.sprite = HeroSelectNevilleSprite;
		HeroSelectLunaImage.sprite = HeroSelectLunaSprite;
		HeroSelectGinnyImage.sprite = HeroSelectGinnySprite;

		// Set Gameplay Hero Data
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
		DataGameplayHeroes.DeckSizeHero1 = 10;
		DataGameplayHeroes.DeckSizeHero2 = 10;
		DataGameplayHeroes.DeckSizeHero3 = 10;
		DataGameplayHeroes.DeckSizeHero4 = 10;
		DataGameplayHeroes.DeckSizeHero5 = 10;
		DataGameplayHeroes.HandSizeHero1 = 5;
		DataGameplayHeroes.HandSizeHero2 = 5;
		DataGameplayHeroes.HandSizeHero3 = 5;
		DataGameplayHeroes.HandSizeHero4 = 5;
		DataGameplayHeroes.HandSizeHero5 = 5;
		DataGameplayHeroes.HealthHero1 = 10;
		DataGameplayHeroes.HealthHero2 = 10;
		DataGameplayHeroes.HealthHero3 = 10;
		DataGameplayHeroes.HealthHero4 = 10;
		DataGameplayHeroes.HealthHero5 = 10;
		DataGameplayHeroes.RoundNumber = 1;
		DataGameplayHeroes.TurnOrderNumber = 1;

		// Set Player Selection Turn
		PlayerSelectionTurn = 1;

		// Play Coroutine
		if (DataPlayerSetup.PlayerBoxSelection == 1) {
			// Update Data
			DataGameplaySetup.HeroAmount = 4;
			PlayerAmount4Image.enabled = false;
			PlayerAmount5Image.enabled = false;
			HeroSelectHarryImage.enabled = true;
			HeroSelectHermioneImage.enabled = true;
			HeroSelectRonImage.enabled = true;
			HeroSelectNevilleImage.enabled = true;
			HeroSelectLunaImage.enabled = false;
			HeroSelectGinnyImage.enabled = false;
			ReselectImage.enabled = true;

			// Start Coroutine to Fade Out Overlay Mid
			StartCoroutine(OverlayFadeOutMid());
		}

		else {
			// Start Coroutine to Fade Out Overlay
			StartCoroutine(OverlayFadeOut());
		}
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

		// Load Pass & Play Game Setup Scene
		Scene10LoadRun.Scene10Load();
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

		// Load Game Type Selection Scene
		Scene04LoadRun.Scene04Load();
	}

	public IEnumerator OverlayFadeInContinue() {
		// Fade Alpha to Overlay
		float ElapsedTime = 0.0f;
		OverlayImage.enabled = true;
		OverlayImage.GetComponent<Image>().color = OverlayAlpha;

		while (ElapsedTime < 0.5f) {
			ElapsedTime += Time.deltaTime * 1.0f;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayAlpha, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		// Load Pass & Play Game Setup Scene
		Scene10LoadRun.Scene10Load();
	}

	public IEnumerator OverlayFadeOutMid() {
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

	public IEnumerator OverlayFadeInMid() {
		// Fade Alpha to Overlay
		float ElapsedTime = 0.0f;
		OverlayImage.enabled = true;
		OverlayImage.GetComponent<Image>().color = OverlayAlpha;

		while (ElapsedTime < 0.5f) {
			ElapsedTime += Time.deltaTime * 1.0f;
			OverlayImage.GetComponent<Image>().color = Color.Lerp(OverlayAlpha, OverlayOriginal, ElapsedTime);
			yield return null;
		}

		// Enable / Disable Buttons
		PlayerAmount4Image.enabled = false;
		PlayerAmount5Image.enabled = false;
		HeroSelectHarryImage.enabled = true;
		HeroSelectHermioneImage.enabled = true;
		HeroSelectRonImage.enabled = true;
		HeroSelectNevilleImage.enabled = true;
		ReselectImage.enabled = true;

		// Enabling Luna & Ginny Selection
		if (DataPlayerSetup.PlayerBoxSelection == 2) {
			HeroSelectLunaImage.enabled = true;
			HeroSelectGinnyImage.enabled = true;
		}

		else if (DataPlayerSetup.PlayerBoxSelection == 3) {
			HeroSelectLunaImage.enabled = true;
			HeroSelectGinnyImage.enabled = true;
		}

		else {
			HeroSelectLunaImage.enabled = false;
			HeroSelectGinnyImage.enabled = false;
		}

		// Start Coroutine to Fade Out Overlay Mid
		StartCoroutine(OverlayFadeOutMid());
	}

	public void PlayerAmount4ButtonClicking() {
		// Update Data
		DataGameplaySetup.HeroAmount = 4;

		// Start Coroutine to Fade In Overlay Mid
		StartCoroutine(OverlayFadeInMid());
	}

	public void PlayerAmount5ButtonClicking() {
		// Update Data
		DataGameplaySetup.HeroAmount = 5;

		// Start Coroutine to Fade In Overlay Mid
		StartCoroutine(OverlayFadeInMid());
	}

	public void HeroSelectHarryButtonClicking() {
		// Determine Player Number To Update Hero
		if (PlayerSelectionTurn == 1) {
			// Update Hero Sprite
			HeroSelectHarryImage.sprite = HeroSelectPlayerChosen1;

			// Update Data
			DataGameplaySetup.Hero1Name = "Harry";

			// Update Turn Number
			PlayerSelectionTurn = 2;
		}

		else if (PlayerSelectionTurn == 2) {
			// Update Hero Sprite
			HeroSelectHarryImage.sprite = HeroSelectPlayerChosen2;

			// Update Data
			DataGameplaySetup.Hero2Name = "Harry";

			// Update Turn Number
			PlayerSelectionTurn = 3;
		}

		else if (PlayerSelectionTurn == 3) {
			// Update Hero Sprite
			HeroSelectHarryImage.sprite = HeroSelectPlayerChosen3;

			// Update Data
			DataGameplaySetup.Hero3Name = "Harry";

			// Update Turn Number
			PlayerSelectionTurn = 4;
		}

		else if (PlayerSelectionTurn == 4) {
			// Update Hero Sprite
			HeroSelectHarryImage.sprite = HeroSelectPlayerChosen4;

			// Update Data
			DataGameplaySetup.Hero4Name = "Harry";

			if (DataGameplaySetup.HeroAmount == 4) {
				// Update Turn Number
				PlayerSelectionTurn = 5;

				// Enable Continue Button
				ContinueImage.enabled = true;
			}

			else if (DataGameplaySetup.HeroAmount == 5) {
				// Update Turn Number
				PlayerSelectionTurn = 5;
			}
		}

		else if (PlayerSelectionTurn == 5) {
			// Update Hero Sprite
			HeroSelectHarryImage.sprite = HeroSelectPlayerChosen5;

			// Update Data
			DataGameplaySetup.Hero5Name = "Harry";

			// Update Turn Number
			PlayerSelectionTurn = 6;

			// Enable Continue Button
			ContinueImage.enabled = true;
		}
	}

	public void HeroSelectHermioneButtonClicking() {
		/// Determine Player Number To Update Hero
		if (PlayerSelectionTurn == 1) {
			// Update Hero Sprite
			HeroSelectHermioneImage.sprite = HeroSelectPlayerChosen1;

			// Update Data
			DataGameplaySetup.Hero1Name = "Hermione";

			// Update Turn Number
			PlayerSelectionTurn = 2;
		}

		else if (PlayerSelectionTurn == 2) {
			// Update Hero Sprite
			HeroSelectHermioneImage.sprite = HeroSelectPlayerChosen2;

			// Update Data
			DataGameplaySetup.Hero2Name = "Hermione";

			// Update Turn Number
			PlayerSelectionTurn = 3;
		}

		else if (PlayerSelectionTurn == 3) {
			// Update Hero Sprite
			HeroSelectHermioneImage.sprite = HeroSelectPlayerChosen3;

			// Update Data
			DataGameplaySetup.Hero3Name = "Hermione";

			// Update Turn Number
			PlayerSelectionTurn = 4;
		}

		else if (PlayerSelectionTurn == 4) {
			// Update Hero Sprite
			HeroSelectHermioneImage.sprite = HeroSelectPlayerChosen4;

			// Update Data
			DataGameplaySetup.Hero4Name = "Hermione";

			if (DataGameplaySetup.HeroAmount == 4) {
				// Update Turn Number
				PlayerSelectionTurn = 5;

				// Enable Continue Button
				ContinueImage.enabled = true;
			}

			else if (DataGameplaySetup.HeroAmount == 5) {
				// Update Turn Number
				PlayerSelectionTurn = 5;
			}
		}

		else if (PlayerSelectionTurn == 5) {
			// Update Hero Sprite
			HeroSelectHermioneImage.sprite = HeroSelectPlayerChosen5;

			// Update Data
			DataGameplaySetup.Hero5Name = "Hermione";

			// Update Turn Number
			PlayerSelectionTurn = 6;

			// Enable Continue Button
			ContinueImage.enabled = true;
		}
	}

	public void HeroSelectRonButtonClicking() {
		// Determine Player Number To Update Hero
		if (PlayerSelectionTurn == 1) {
			// Update Hero Sprite
			HeroSelectRonImage.sprite = HeroSelectPlayerChosen1;

			// Update Data
			DataGameplaySetup.Hero1Name = "Ron";

			// Update Turn Number
			PlayerSelectionTurn = 2;
		}

		else if (PlayerSelectionTurn == 2) {
			// Update Hero Sprite
			HeroSelectRonImage.sprite = HeroSelectPlayerChosen2;

			// Update Data
			DataGameplaySetup.Hero2Name = "Ron";

			// Update Turn Number
			PlayerSelectionTurn = 3;
		}

		else if (PlayerSelectionTurn == 3) {
			// Update Hero Sprite
			HeroSelectRonImage.sprite = HeroSelectPlayerChosen3;

			// Update Data
			DataGameplaySetup.Hero3Name = "Ron";

			// Update Turn Number
			PlayerSelectionTurn = 4;
		}

		else if (PlayerSelectionTurn == 4) {
			// Update Hero Sprite
			HeroSelectRonImage.sprite = HeroSelectPlayerChosen4;

			// Update Data
			DataGameplaySetup.Hero4Name = "Ron";

			if (DataGameplaySetup.HeroAmount == 4) {
				// Update Turn Number
				PlayerSelectionTurn = 5;

				// Enable Continue Button
				ContinueImage.enabled = true;
			}

			else if (DataGameplaySetup.HeroAmount == 5) {
				// Update Turn Number
				PlayerSelectionTurn = 5;
			}
		}

		else if (PlayerSelectionTurn == 5) {
			// Update Hero Sprite
			HeroSelectRonImage.sprite = HeroSelectPlayerChosen5;

			// Update Data
			DataGameplaySetup.Hero5Name = "Ron";

			// Update Turn Number
			PlayerSelectionTurn = 6;

			// Enable Continue Button
			ContinueImage.enabled = true;
		}
	}

	public void HeroSelectNevilleButtonClicking() {
		// Determine Player Number To Update Hero
		if (PlayerSelectionTurn == 1) {
			// Update Hero Sprite
			HeroSelectNevilleImage.sprite = HeroSelectPlayerChosen1;

			// Update Data
			DataGameplaySetup.Hero1Name = "Neville";

			// Update Turn Number
			PlayerSelectionTurn = 2;
		}

		else if (PlayerSelectionTurn == 2) {
			// Update Hero Sprite
			HeroSelectNevilleImage.sprite = HeroSelectPlayerChosen2;

			// Update Data
			DataGameplaySetup.Hero2Name = "Neville";

			// Update Turn Number
			PlayerSelectionTurn = 3;
		}

		else if (PlayerSelectionTurn == 3) {
			// Update Hero Sprite
			HeroSelectNevilleImage.sprite = HeroSelectPlayerChosen3;

			// Update Data
			DataGameplaySetup.Hero3Name = "Neville";

			// Update Turn Number
			PlayerSelectionTurn = 4;
		}

		else if (PlayerSelectionTurn == 4) {
			// Update Hero Sprite
			HeroSelectNevilleImage.sprite = HeroSelectPlayerChosen4;

			// Update Data
			DataGameplaySetup.Hero4Name = "Neville";

			if (DataGameplaySetup.HeroAmount == 4) {
				// Update Turn Number
				PlayerSelectionTurn = 5;

				// Enable Continue Button
				ContinueImage.enabled = true;
			}

			else if (DataGameplaySetup.HeroAmount == 5) {
				// Update Turn Number
				PlayerSelectionTurn = 5;
			}
		}

		else if (PlayerSelectionTurn == 5) {
			// Update Hero Sprite
			HeroSelectNevilleImage.sprite = HeroSelectPlayerChosen5;

			// Update Data
			DataGameplaySetup.Hero5Name = "Neville";

			// Update Turn Number
			PlayerSelectionTurn = 6;

			// Enable Continue Button
			ContinueImage.enabled = true;
		}
	}

	public void HeroSelectLunaButtonClicking() {
		// Determine Player Number To Update Hero
		if (PlayerSelectionTurn == 1) {
			// Update Hero Sprite
			HeroSelectLunaImage.sprite = HeroSelectPlayerChosen1;

			// Update Data
			DataGameplaySetup.Hero1Name = "Luna";

			// Update Turn Number
			PlayerSelectionTurn = 2;
		}

		else if (PlayerSelectionTurn == 2) {
			// Update Hero Sprite
			HeroSelectLunaImage.sprite = HeroSelectPlayerChosen2;

			// Update Data
			DataGameplaySetup.Hero2Name = "Luna";

			// Update Turn Number
			PlayerSelectionTurn = 3;
		}

		else if (PlayerSelectionTurn == 3) {
			// Update Hero Sprite
			HeroSelectLunaImage.sprite = HeroSelectPlayerChosen3;

			// Update Data
			DataGameplaySetup.Hero3Name = "Luna";

			// Update Turn Number
			PlayerSelectionTurn = 4;
		}

		else if (PlayerSelectionTurn == 4) {
			// Update Hero Sprite
			HeroSelectLunaImage.sprite = HeroSelectPlayerChosen4;

			// Update Data
			DataGameplaySetup.Hero4Name = "Luna";

			if (DataGameplaySetup.HeroAmount == 4) {
				// Update Turn Number
				PlayerSelectionTurn = 5;

				// Enable Continue Button
				ContinueImage.enabled = true;
			}

			else if (DataGameplaySetup.HeroAmount == 5) {
				// Update Turn Number
				PlayerSelectionTurn = 5;
			}
		}

		else if (PlayerSelectionTurn == 5) {
			// Update Hero Sprite
			HeroSelectLunaImage.sprite = HeroSelectPlayerChosen5;

			// Update Data
			DataGameplaySetup.Hero5Name = "Luna";

			// Update Turn Number
			PlayerSelectionTurn = 6;

			// Enable Continue Button
			ContinueImage.enabled = true;
		}
	}

	public void HeroSelectGinnyButtonClicking() {
		// Determine Player Number To Update Hero
		if (PlayerSelectionTurn == 1) {
			// Update Hero Sprite
			HeroSelectGinnyImage.sprite = HeroSelectPlayerChosen1;

			// Update Data
			DataGameplaySetup.Hero1Name = "Ginny";

			// Update Turn Number
			PlayerSelectionTurn = 2;
		}

		else if (PlayerSelectionTurn == 2) {
			// Update Hero Sprite
			HeroSelectGinnyImage.sprite = HeroSelectPlayerChosen2;

			// Update Data
			DataGameplaySetup.Hero2Name = "Ginny";

			// Update Turn Number
			PlayerSelectionTurn = 3;
		}

		else if (PlayerSelectionTurn == 3) {
			// Update Hero Sprite
			HeroSelectGinnyImage.sprite = HeroSelectPlayerChosen3;

			// Update Data
			DataGameplaySetup.Hero3Name = "Ginny";

			// Update Turn Number
			PlayerSelectionTurn = 4;
		}

		else if (PlayerSelectionTurn == 4) {
			// Update Hero Sprite
			HeroSelectGinnyImage.sprite = HeroSelectPlayerChosen4;

			// Update Data
			DataGameplaySetup.Hero4Name = "Ginny";

			if (DataGameplaySetup.HeroAmount == 4) {
				// Update Turn Number
				PlayerSelectionTurn = 5;

				// Enable Continue Button
				ContinueImage.enabled = true;
			}

			else if (DataGameplaySetup.HeroAmount == 5) {
				// Update Turn Number
				PlayerSelectionTurn = 5;
			}
		}

		else if (PlayerSelectionTurn == 5) {
			// Update Hero Sprite
			HeroSelectGinnyImage.sprite = HeroSelectPlayerChosen5;

			// Update Data
			DataGameplaySetup.Hero5Name = "Ginny";

			// Update Turn Number
			PlayerSelectionTurn = 6;

			// Enable Continue Button
			ContinueImage.enabled = true;
		}
	}

	public void ReselectButtonClicking() {
		// Update Data
		PlayerSelectionTurn = 1;
		DataGameplaySetup.Hero1Name = "None";
		DataGameplaySetup.Hero2Name = "None";
		DataGameplaySetup.Hero3Name = "None";
		DataGameplaySetup.Hero4Name = "None";
		DataGameplaySetup.Hero5Name = "None";
		DataGameplaySetup.TurnOrderHero1 = 0;
		DataGameplaySetup.TurnOrderHero2 = 0;
		DataGameplaySetup.TurnOrderHero3 = 0;
		DataGameplaySetup.TurnOrderHero4 = 0;
		DataGameplaySetup.TurnOrderHero5 = 0;

		// Disable Continue Button
		ContinueImage.enabled = false;

		// Revert To Hero Original Sprites
		HeroSelectHarryImage.sprite = HeroSelectHarrySprite;
		HeroSelectHermioneImage.sprite = HeroSelectHermioneSprite;
		HeroSelectRonImage.sprite = HeroSelectRonSprite;
		HeroSelectNevilleImage.sprite = HeroSelectNevilleSprite;
		HeroSelectLunaImage.sprite = HeroSelectLunaSprite;
		HeroSelectGinnyImage.sprite = HeroSelectGinnySprite;
	}

	public void ContinueButtonClicking() {
		// Update Data
		PlayerSelectionTurn = 0;
		DataGameplaySetup.TurnOrderHero1 = 1;
		DataGameplaySetup.TurnOrderHero2 = 2;
		DataGameplaySetup.TurnOrderHero3 = 3;
		DataGameplaySetup.TurnOrderHero4 = 4;
		DataGameplaySetup.TurnOrderHero5 = 5;

		// Start Coroutine to Fade In Overlay Continue
		StartCoroutine(OverlayFadeInContinue());
	}

	public void BackButtonClicking() {
		// Update Data
		DataPlayerSetup.PlayerGameTypeSelection = 0;
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

		// Start Coroutine to Fade In Overlay Back
		StartCoroutine(OverlayFadeInBack());
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}