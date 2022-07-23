using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ScenePlassPlayGameplay : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Upper HUD
	public Text RoundText;
	public Text TurnText;
	public Text LocationText;

	// Lower HUD
	public Text LowerHeartNumber;
	public Text LowerCoinNumber;
	public Text LowerBoltNumber;

	// Hero Sprites
	public Sprite HeroHarry;
	public Sprite HeroHermione;
	public Sprite HeroRon;
	public Sprite HeroNeville;
	public Sprite HeroLuna;
	public Sprite HeroGinny;

	// 4-Hero HUD
	public Image FourHeroSideHUD;
	public Text FourHeroSideTitle;
	public Text FourHeroSideHeroATitle;
	public Image FourHeroSideHeroAImage;
	public Image FourHeroSideHeroAHeartIcon;
	public Image FourHeroSideHeroACoinIcon;
	public Image FourHeroSideHeroABoltIcon;
	public Text FourHeroSideHeroAHeartNumber;
	public Text FourHeroSideHeroACoinNumber;
	public Text FourHeroSideHeroABoltNumber;
	public Text FourHeroSideHeroBTitle;
	public Image FourHeroSideHeroBImage;
	public Image FourHeroSideHeroBHeartIcon;
	public Image FourHeroSideHeroBCoinIcon;
	public Image FourHeroSideHeroBBoltIcon;
	public Text FourHeroSideHeroBHeartNumber;
	public Text FourHeroSideHeroBCoinNumber;
	public Text FourHeroSideHeroBBoltNumber;
	public Text FourHeroSideHeroCTitle;
	public Image FourHeroSideHeroCImage;
	public Image FourHeroSideHeroCHeartIcon;
	public Image FourHeroSideHeroCCoinIcon;
	public Image FourHeroSideHeroCBoltIcon;
	public Text FourHeroSideHeroCHeartNumber;
	public Text FourHeroSideHeroCCoinNumber;
	public Text FourHeroSideHeroCBoltNumber;

	// 5-Hero HUD
	public Image FiveHeroSideHUD;
	public Text FiveHeroSideTitle;
	public Text FiveHeroSideHeroATitle;
	public Image FiveHeroSideHeroAImage;
	public Image FiveHeroSideHeroAHeartIcon;
	public Image FiveHeroSideHeroACoinIcon;
	public Image FiveHeroSideHeroABoltIcon;
	public Text FiveHeroSideHeroAHeartNumber;
	public Text FiveHeroSideHeroACoinNumber;
	public Text FiveHeroSideHeroABoltNumber;
	public Text FiveHeroSideHeroBTitle;
	public Image FiveHeroSideHeroBImage;
	public Image FiveHeroSideHeroBHeartIcon;
	public Image FiveHeroSideHeroBCoinIcon;
	public Image FiveHeroSideHeroBBoltIcon;
	public Text FiveHeroSideHeroBHeartNumber;
	public Text FiveHeroSideHeroBCoinNumber;
	public Text FiveHeroSideHeroBBoltNumber;
	public Text FiveHeroSideHeroCTitle;
	public Image FiveHeroSideHeroCImage;
	public Image FiveHeroSideHeroCHeartIcon;
	public Image FiveHeroSideHeroCCoinIcon;
	public Image FiveHeroSideHeroCBoltIcon;
	public Text FiveHeroSideHeroCHeartNumber;
	public Text FiveHeroSideHeroCCoinNumber;
	public Text FiveHeroSideHeroCBoltNumber;
	public Text FiveHeroSideHeroDTitle;
	public Image FiveHeroSideHeroDImage;
	public Image FiveHeroSideHeroDHeartIcon;
	public Image FiveHeroSideHeroDCoinIcon;
	public Image FiveHeroSideHeroDBoltIcon;
	public Text FiveHeroSideHeroDHeartNumber;
	public Text FiveHeroSideHeroDCoinNumber;
	public Text FiveHeroSideHeroDBoltNumber;


	// Overlay Image
	public Image OverlayImage;

	public Color OverlayOriginal = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	public Color OverlayAlpha = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	Sprite Hero1Sprite;
	Sprite Hero2Sprite;
	Sprite Hero3Sprite;
	Sprite Hero4Sprite;
	Sprite Hero5Sprite;
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// Overlay Starting Color
		OverlayImage.GetComponent<Image>().color = OverlayOriginal;

		// Determine Hero Side HUD
		DetermineHeroSideHUD();

		// Start Coroutine to Fade Out Overlay
		StartCoroutine(OverlayFadeOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		UpdateSprites();
		UpdateAllTexts();
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
	}

	public void DetermineHeroSideHUD() {
		// 4 Heroes
		if (DataGameplaySetup.HeroAmount == 4) {
			// 4-Hero HUD
			FourHeroSideHUD.enabled = true;
			FourHeroSideTitle.enabled = true;
			FourHeroSideHeroATitle.enabled = true;
			FourHeroSideHeroAImage.enabled = true;
			FourHeroSideHeroAHeartIcon.enabled = true;
			FourHeroSideHeroACoinIcon.enabled = true;
			FourHeroSideHeroABoltIcon.enabled = true;
			FourHeroSideHeroAHeartNumber.enabled = true;
			FourHeroSideHeroACoinNumber.enabled = true;
			FourHeroSideHeroABoltNumber.enabled = true;
			FourHeroSideHeroBTitle.enabled = true;
			FourHeroSideHeroBImage.enabled = true;
			FourHeroSideHeroBHeartIcon.enabled = true;
			FourHeroSideHeroBCoinIcon.enabled = true;
			FourHeroSideHeroBBoltIcon.enabled = true;
			FourHeroSideHeroBHeartNumber.enabled = true;
			FourHeroSideHeroBCoinNumber.enabled = true;
			FourHeroSideHeroBBoltNumber.enabled = true;
			FourHeroSideHeroCTitle.enabled = true;
			FourHeroSideHeroCImage.enabled = true;
			FourHeroSideHeroCHeartIcon.enabled = true;
			FourHeroSideHeroCCoinIcon.enabled = true;
			FourHeroSideHeroCBoltIcon.enabled = true;
			FourHeroSideHeroCHeartNumber.enabled = true;
			FourHeroSideHeroCCoinNumber.enabled = true;
			FourHeroSideHeroCBoltNumber.enabled = true;

			// 5-Hero HUD
			FiveHeroSideHUD.enabled = false;
			FiveHeroSideTitle.enabled = false;
			FiveHeroSideHeroATitle.enabled = false;
			FiveHeroSideHeroAImage.enabled = false;
			FiveHeroSideHeroAHeartIcon.enabled = false;
			FiveHeroSideHeroACoinIcon.enabled = false;
			FiveHeroSideHeroABoltIcon.enabled = false;
			FiveHeroSideHeroAHeartNumber.enabled = false;
			FiveHeroSideHeroACoinNumber.enabled = false;
			FiveHeroSideHeroABoltNumber.enabled = false;
			FiveHeroSideHeroBTitle.enabled = false;
			FiveHeroSideHeroBImage.enabled = false;
			FiveHeroSideHeroBHeartIcon.enabled = false;
			FiveHeroSideHeroBCoinIcon.enabled = false;
			FiveHeroSideHeroBBoltIcon.enabled = false;
			FiveHeroSideHeroBHeartNumber.enabled = false;
			FiveHeroSideHeroBCoinNumber.enabled = false;
			FiveHeroSideHeroBBoltNumber.enabled = false;
			FiveHeroSideHeroCTitle.enabled = false;
			FiveHeroSideHeroCImage.enabled = false;
			FiveHeroSideHeroCHeartIcon.enabled = false;
			FiveHeroSideHeroCCoinIcon.enabled = false;
			FiveHeroSideHeroCBoltIcon.enabled = false;
			FiveHeroSideHeroCHeartNumber.enabled = false;
			FiveHeroSideHeroCCoinNumber.enabled = false;
			FiveHeroSideHeroCBoltNumber.enabled = false;
			FiveHeroSideHeroDTitle.enabled = false;
			FiveHeroSideHeroDImage.enabled = false;
			FiveHeroSideHeroDHeartIcon.enabled = false;
			FiveHeroSideHeroDCoinIcon.enabled = false;
			FiveHeroSideHeroDBoltIcon.enabled = false;
			FiveHeroSideHeroDHeartNumber.enabled = false;
			FiveHeroSideHeroDCoinNumber.enabled = false;
			FiveHeroSideHeroDBoltNumber.enabled = false;
		}

		// 5 Heroes
		else if (DataGameplaySetup.HeroAmount == 5) {
			// 4-Hero HUD
			FourHeroSideHUD.enabled = false;
			FourHeroSideTitle.enabled = false;
			FourHeroSideHeroATitle.enabled = false;
			FourHeroSideHeroAImage.enabled = false;
			FourHeroSideHeroAHeartIcon.enabled = false;
			FourHeroSideHeroACoinIcon.enabled = false;
			FourHeroSideHeroABoltIcon.enabled = false;
			FourHeroSideHeroAHeartNumber.enabled = false;
			FourHeroSideHeroACoinNumber.enabled = false;
			FourHeroSideHeroABoltNumber.enabled = false;
			FourHeroSideHeroBTitle.enabled = false;
			FourHeroSideHeroBImage.enabled = false;
			FourHeroSideHeroBHeartIcon.enabled = false;
			FourHeroSideHeroBCoinIcon.enabled = false;
			FourHeroSideHeroBBoltIcon.enabled = false;
			FourHeroSideHeroBHeartNumber.enabled = false;
			FourHeroSideHeroBCoinNumber.enabled = false;
			FourHeroSideHeroBBoltNumber.enabled = false;
			FourHeroSideHeroCTitle.enabled = false;
			FourHeroSideHeroCImage.enabled = false;
			FourHeroSideHeroCHeartIcon.enabled = false;
			FourHeroSideHeroCCoinIcon.enabled = false;
			FourHeroSideHeroCBoltIcon.enabled = false;
			FourHeroSideHeroCHeartNumber.enabled = false;
			FourHeroSideHeroCCoinNumber.enabled = false;
			FourHeroSideHeroCBoltNumber.enabled = false;

			// 5-Hero HUD
			FiveHeroSideHUD.enabled = true;
			FiveHeroSideTitle.enabled = true;
			FiveHeroSideHeroATitle.enabled = true;
			FiveHeroSideHeroAImage.enabled = true;
			FiveHeroSideHeroAHeartIcon.enabled = true;
			FiveHeroSideHeroACoinIcon.enabled = true;
			FiveHeroSideHeroABoltIcon.enabled = true;
			FiveHeroSideHeroAHeartNumber.enabled = true;
			FiveHeroSideHeroACoinNumber.enabled = true;
			FiveHeroSideHeroABoltNumber.enabled = true;
			FiveHeroSideHeroBTitle.enabled = true;
			FiveHeroSideHeroBImage.enabled = true;
			FiveHeroSideHeroBHeartIcon.enabled = true;
			FiveHeroSideHeroBCoinIcon.enabled = true;
			FiveHeroSideHeroBBoltIcon.enabled = true;
			FiveHeroSideHeroBHeartNumber.enabled = true;
			FiveHeroSideHeroBCoinNumber.enabled = true;
			FiveHeroSideHeroBBoltNumber.enabled = true;
			FiveHeroSideHeroCTitle.enabled = true;
			FiveHeroSideHeroCImage.enabled = true;
			FiveHeroSideHeroCHeartIcon.enabled = true;
			FiveHeroSideHeroCCoinIcon.enabled = true;
			FiveHeroSideHeroCBoltIcon.enabled = true;
			FiveHeroSideHeroCHeartNumber.enabled = true;
			FiveHeroSideHeroCCoinNumber.enabled = true;
			FiveHeroSideHeroCBoltNumber.enabled = true;
			FiveHeroSideHeroDTitle.enabled = true;
			FiveHeroSideHeroDImage.enabled = true;
			FiveHeroSideHeroDHeartIcon.enabled = true;
			FiveHeroSideHeroDCoinIcon.enabled = true;
			FiveHeroSideHeroDBoltIcon.enabled = true;
			FiveHeroSideHeroDHeartNumber.enabled = true;
			FiveHeroSideHeroDCoinNumber.enabled = true;
			FiveHeroSideHeroDBoltNumber.enabled = true;
		}
	}

	public void UpdateAllTexts() {
		// Upper HUD
		RoundText.text = DataGameplayHeroes.RoundNumber.ToString();
		TurnText.text = DataGameplayHeroes.TurnOrderNumber.ToString();
		LocationText.text = DataGameplayCards.LocationCurrentCardAmount.ToString() + " / " + DataGameplayCards.LocationCardAmount.ToString();

		// Lower HUD
		if (DataGameplayHeroes.TurnOrderNumber == 1) {
			LowerHeartNumber.text = DataGameplayHeroes.HealthHero1.ToString();
			LowerCoinNumber.text = DataGameplayHeroes.CoinSizeHero1.ToString();
			LowerBoltNumber.text = DataGameplayHeroes.BoltSizeHero1.ToString();
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 2) {
			LowerHeartNumber.text = DataGameplayHeroes.HealthHero2.ToString();
			LowerCoinNumber.text = DataGameplayHeroes.CoinSizeHero2.ToString();
			LowerBoltNumber.text = DataGameplayHeroes.BoltSizeHero2.ToString();
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 3) {
			LowerHeartNumber.text = DataGameplayHeroes.HealthHero3.ToString();
			LowerCoinNumber.text = DataGameplayHeroes.CoinSizeHero3.ToString();
			LowerBoltNumber.text = DataGameplayHeroes.BoltSizeHero3.ToString();
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 4) {
			LowerHeartNumber.text = DataGameplayHeroes.HealthHero4.ToString();
			LowerCoinNumber.text = DataGameplayHeroes.CoinSizeHero4.ToString();
			LowerBoltNumber.text = DataGameplayHeroes.BoltSizeHero4.ToString();
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 5) {
			LowerHeartNumber.text = DataGameplayHeroes.HealthHero5.ToString();
			LowerCoinNumber.text = DataGameplayHeroes.CoinSizeHero5.ToString();
			LowerBoltNumber.text = DataGameplayHeroes.BoltSizeHero5.ToString();
		}

		// Side HUD
		if (DataGameplayHeroes.TurnOrderNumber == 1) {
			// 4-Hero
			FourHeroSideHeroATitle.text = "Player 2: " + DataGameplaySetup.Hero2Name.ToString();
			FourHeroSideHeroAImage.sprite = Hero2Sprite;
			FourHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero2.ToString();
			FourHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero2.ToString();
			FourHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero2.ToString();

			FourHeroSideHeroBTitle.text = "Player 3: " + DataGameplaySetup.Hero3Name.ToString();
			FourHeroSideHeroBImage.sprite = Hero3Sprite;
			FourHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero3.ToString();
			FourHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero3.ToString();
			FourHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero3.ToString();

			FourHeroSideHeroCTitle.text = "Player 4: " + DataGameplaySetup.Hero4Name.ToString();
			FourHeroSideHeroCImage.sprite = Hero4Sprite;
			FourHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero4.ToString();
			FourHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero4.ToString();
			FourHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero4.ToString();

			// 5-Hero
			FiveHeroSideHeroATitle.text = "Player 2: " + DataGameplaySetup.Hero2Name.ToString();
			FiveHeroSideHeroAImage.sprite = Hero2Sprite;
			FiveHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero2.ToString();
			FiveHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero2.ToString();
			FiveHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero2.ToString();

			FiveHeroSideHeroBTitle.text = "Player 3: " + DataGameplaySetup.Hero3Name.ToString();
			FiveHeroSideHeroBImage.sprite = Hero3Sprite;
			FiveHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero3.ToString();
			FiveHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero3.ToString();
			FiveHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero3.ToString();

			FiveHeroSideHeroCTitle.text = "Player 4: " + DataGameplaySetup.Hero4Name.ToString();
			FiveHeroSideHeroCImage.sprite = Hero4Sprite;
			FiveHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero4.ToString();
			FiveHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero4.ToString();
			FiveHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero4.ToString();

			FiveHeroSideHeroDTitle.text = "Player 5: " + DataGameplaySetup.Hero5Name.ToString();
			FiveHeroSideHeroDImage.sprite = Hero5Sprite;
			FiveHeroSideHeroDHeartNumber.text = DataGameplayHeroes.HealthHero5.ToString();
			FiveHeroSideHeroDCoinNumber.text = DataGameplayHeroes.CoinSizeHero5.ToString();
			FiveHeroSideHeroDBoltNumber.text = DataGameplayHeroes.BoltSizeHero5.ToString();
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 2) {
			// 4-Hero
			FourHeroSideHeroATitle.text = "Player 1: " + DataGameplaySetup.Hero1Name.ToString();
			FourHeroSideHeroAImage.sprite = Hero1Sprite;
			FourHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero1.ToString();
			FourHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero1.ToString();
			FourHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero1.ToString();

			FourHeroSideHeroBTitle.text = "Player 3: " + DataGameplaySetup.Hero3Name.ToString();
			FourHeroSideHeroBImage.sprite = Hero3Sprite;
			FourHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero3.ToString();
			FourHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero3.ToString();
			FourHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero3.ToString();

			FourHeroSideHeroCTitle.text = "Player 4: " + DataGameplaySetup.Hero4Name.ToString();
			FourHeroSideHeroCImage.sprite = Hero4Sprite;
			FourHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero4.ToString();
			FourHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero4.ToString();
			FourHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero4.ToString();

			// 5-Hero
			FiveHeroSideHeroATitle.text = "Player 1: " + DataGameplaySetup.Hero1Name.ToString();
			FiveHeroSideHeroAImage.sprite = Hero1Sprite;
			FiveHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero1.ToString();
			FiveHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero1.ToString();
			FiveHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero1.ToString();

			FiveHeroSideHeroBTitle.text = "Player 3: " + DataGameplaySetup.Hero3Name.ToString();
			FiveHeroSideHeroBImage.sprite = Hero3Sprite;
			FiveHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero3.ToString();
			FiveHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero3.ToString();
			FiveHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero3.ToString();

			FiveHeroSideHeroCTitle.text = "Player 4: " + DataGameplaySetup.Hero4Name.ToString();
			FiveHeroSideHeroCImage.sprite = Hero4Sprite;
			FiveHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero4.ToString();
			FiveHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero4.ToString();
			FiveHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero4.ToString();

			FiveHeroSideHeroDTitle.text = "Player 5: " + DataGameplaySetup.Hero5Name.ToString();
			FiveHeroSideHeroDImage.sprite = Hero5Sprite;
			FiveHeroSideHeroDHeartNumber.text = DataGameplayHeroes.HealthHero5.ToString();
			FiveHeroSideHeroDCoinNumber.text = DataGameplayHeroes.CoinSizeHero5.ToString();
			FiveHeroSideHeroDBoltNumber.text = DataGameplayHeroes.BoltSizeHero5.ToString();
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 3) {
			// 4-Hero
			FourHeroSideHeroATitle.text = "Player 1: " + DataGameplaySetup.Hero1Name.ToString();
			FourHeroSideHeroAImage.sprite = Hero1Sprite;
			FourHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero1.ToString();
			FourHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero1.ToString();
			FourHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero1.ToString();

			FourHeroSideHeroBTitle.text = "Player 2: " + DataGameplaySetup.Hero2Name.ToString();
			FourHeroSideHeroBImage.sprite = Hero2Sprite;
			FourHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero2.ToString();
			FourHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero2.ToString();
			FourHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero2.ToString();

			FourHeroSideHeroCTitle.text = "Player 4: " + DataGameplaySetup.Hero4Name.ToString();
			FourHeroSideHeroCImage.sprite = Hero4Sprite;
			FourHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero4.ToString();
			FourHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero4.ToString();
			FourHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero4.ToString();

			// 5-Hero
			FiveHeroSideHeroATitle.text = "Player 1: " + DataGameplaySetup.Hero1Name.ToString();
			FiveHeroSideHeroAImage.sprite = Hero1Sprite;
			FiveHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero1.ToString();
			FiveHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero1.ToString();
			FiveHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero1.ToString();

			FiveHeroSideHeroBTitle.text = "Player 2: " + DataGameplaySetup.Hero2Name.ToString();
			FiveHeroSideHeroBImage.sprite = Hero2Sprite;
			FiveHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero2.ToString();
			FiveHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero2.ToString();
			FiveHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero2.ToString();

			FiveHeroSideHeroCTitle.text = "Player 4: " + DataGameplaySetup.Hero4Name.ToString();
			FiveHeroSideHeroCImage.sprite = Hero4Sprite;
			FiveHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero4.ToString();
			FiveHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero4.ToString();
			FiveHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero4.ToString();

			FiveHeroSideHeroDTitle.text = "Player 5: " + DataGameplaySetup.Hero5Name.ToString();
			FiveHeroSideHeroDImage.sprite = Hero5Sprite;
			FiveHeroSideHeroDHeartNumber.text = DataGameplayHeroes.HealthHero5.ToString();
			FiveHeroSideHeroDCoinNumber.text = DataGameplayHeroes.CoinSizeHero5.ToString();
			FiveHeroSideHeroDBoltNumber.text = DataGameplayHeroes.BoltSizeHero5.ToString();
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 4) {
			// 4-Hero
			FourHeroSideHeroATitle.text = "Player 1: " + DataGameplaySetup.Hero1Name.ToString();
			FourHeroSideHeroAImage.sprite = Hero1Sprite;
			FourHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero1.ToString();
			FourHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero1.ToString();
			FourHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero1.ToString();

			FourHeroSideHeroBTitle.text = "Player 2: " + DataGameplaySetup.Hero2Name.ToString();
			FourHeroSideHeroBImage.sprite = Hero2Sprite;
			FourHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero2.ToString();
			FourHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero2.ToString();
			FourHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero2.ToString();

			FourHeroSideHeroCTitle.text = "Player 3: " + DataGameplaySetup.Hero3Name.ToString();
			FourHeroSideHeroCImage.sprite = Hero3Sprite;
			FourHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero3.ToString();
			FourHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero3.ToString();
			FourHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero3.ToString();

			// 5-Hero
			FiveHeroSideHeroATitle.text = "Player 1: " + DataGameplaySetup.Hero1Name.ToString();
			FiveHeroSideHeroAImage.sprite = Hero1Sprite;
			FiveHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero1.ToString();
			FiveHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero1.ToString();
			FiveHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero1.ToString();

			FiveHeroSideHeroBTitle.text = "Player 2: " + DataGameplaySetup.Hero2Name.ToString();
			FiveHeroSideHeroBImage.sprite = Hero2Sprite;
			FiveHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero2.ToString();
			FiveHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero2.ToString();
			FiveHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero2.ToString();

			FiveHeroSideHeroCTitle.text = "Player 3: " + DataGameplaySetup.Hero3Name.ToString();
			FiveHeroSideHeroCImage.sprite = Hero3Sprite;
			FiveHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero3.ToString();
			FiveHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero3.ToString();
			FiveHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero3.ToString();

			FiveHeroSideHeroDTitle.text = "Player 5: " + DataGameplaySetup.Hero5Name.ToString();
			FiveHeroSideHeroDImage.sprite = Hero5Sprite;
			FiveHeroSideHeroDHeartNumber.text = DataGameplayHeroes.HealthHero5.ToString();
			FiveHeroSideHeroDCoinNumber.text = DataGameplayHeroes.CoinSizeHero5.ToString();
			FiveHeroSideHeroDBoltNumber.text = DataGameplayHeroes.BoltSizeHero5.ToString();
		}

		else if (DataGameplayHeroes.TurnOrderNumber == 5) {
			// 4-Hero
			FourHeroSideHeroATitle.text = "Player 1: " + DataGameplaySetup.Hero1Name.ToString();
			FourHeroSideHeroAImage.sprite = Hero1Sprite;
			FourHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero1.ToString();
			FourHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero1.ToString();
			FourHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero1.ToString();

			FourHeroSideHeroBTitle.text = "Player 2: " + DataGameplaySetup.Hero2Name.ToString();
			FourHeroSideHeroBImage.sprite = Hero2Sprite;
			FourHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero2.ToString();
			FourHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero2.ToString();
			FourHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero2.ToString();

			FourHeroSideHeroCTitle.text = "Player 3: " + DataGameplaySetup.Hero3Name.ToString();
			FourHeroSideHeroCImage.sprite = Hero3Sprite;
			FourHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero3.ToString();
			FourHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero3.ToString();
			FourHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero3.ToString();

			// 5-Hero
			FiveHeroSideHeroATitle.text = "Player 1: " + DataGameplaySetup.Hero1Name.ToString();
			FiveHeroSideHeroAImage.sprite = Hero1Sprite;
			FiveHeroSideHeroAHeartNumber.text = DataGameplayHeroes.HealthHero1.ToString();
			FiveHeroSideHeroACoinNumber.text = DataGameplayHeroes.CoinSizeHero1.ToString();
			FiveHeroSideHeroABoltNumber.text = DataGameplayHeroes.BoltSizeHero1.ToString();

			FiveHeroSideHeroBTitle.text = "Player 2: " + DataGameplaySetup.Hero2Name.ToString();
			FiveHeroSideHeroBImage.sprite = Hero2Sprite;
			FiveHeroSideHeroBHeartNumber.text = DataGameplayHeroes.HealthHero2.ToString();
			FiveHeroSideHeroBCoinNumber.text = DataGameplayHeroes.CoinSizeHero2.ToString();
			FiveHeroSideHeroBBoltNumber.text = DataGameplayHeroes.BoltSizeHero2.ToString();

			FiveHeroSideHeroCTitle.text = "Player 3: " + DataGameplaySetup.Hero3Name.ToString();
			FiveHeroSideHeroCImage.sprite = Hero3Sprite;
			FiveHeroSideHeroCHeartNumber.text = DataGameplayHeroes.HealthHero3.ToString();
			FiveHeroSideHeroCCoinNumber.text = DataGameplayHeroes.CoinSizeHero3.ToString();
			FiveHeroSideHeroCBoltNumber.text = DataGameplayHeroes.BoltSizeHero3.ToString();

			FiveHeroSideHeroDTitle.text = "Player 4: " + DataGameplaySetup.Hero4Name.ToString();
			FiveHeroSideHeroDImage.sprite = Hero4Sprite;
			FiveHeroSideHeroDHeartNumber.text = DataGameplayHeroes.HealthHero4.ToString();
			FiveHeroSideHeroDCoinNumber.text = DataGameplayHeroes.CoinSizeHero4.ToString();
			FiveHeroSideHeroDBoltNumber.text = DataGameplayHeroes.BoltSizeHero4.ToString();
		}
	}

	public void UpdateSprites() {
		// Player 1
		if (DataGameplaySetup.Hero1Name == "Harry") {
			Hero1Sprite = HeroHarry;
		}

		else if (DataGameplaySetup.Hero1Name == "Hermione") {
			Hero1Sprite = HeroHermione;
		}

		else if (DataGameplaySetup.Hero1Name == "Ron") {
			Hero1Sprite = HeroRon;
		}

		else if (DataGameplaySetup.Hero1Name == "Neville") {
			Hero1Sprite = HeroNeville;
		}

		else if (DataGameplaySetup.Hero1Name == "Luna") {
			Hero1Sprite = HeroLuna;
		}

		else if (DataGameplaySetup.Hero1Name == "Ginny") {
			Hero1Sprite = HeroGinny;
		}

		// Player 2
		if (DataGameplaySetup.Hero2Name == "Harry") {
			Hero2Sprite = HeroHarry;
		}

		else if (DataGameplaySetup.Hero2Name == "Hermione") {
			Hero2Sprite = HeroHermione;
		}

		else if (DataGameplaySetup.Hero2Name == "Ron") {
			Hero2Sprite = HeroRon;
		}

		else if (DataGameplaySetup.Hero2Name == "Neville") {
			Hero2Sprite = HeroNeville;
		}

		else if (DataGameplaySetup.Hero2Name == "Luna") {
			Hero2Sprite = HeroLuna;
		}

		else if (DataGameplaySetup.Hero2Name == "Ginny") {
			Hero2Sprite = HeroGinny;
		}

		// Player 3
		if (DataGameplaySetup.Hero3Name == "Harry") {
			Hero3Sprite = HeroHarry;
		}

		else if (DataGameplaySetup.Hero3Name == "Hermione") {
			Hero3Sprite = HeroHermione;
		}

		else if (DataGameplaySetup.Hero3Name == "Ron") {
			Hero3Sprite = HeroRon;
		}

		else if (DataGameplaySetup.Hero3Name == "Neville") {
			Hero3Sprite = HeroNeville;
		}

		else if (DataGameplaySetup.Hero3Name == "Luna") {
			Hero3Sprite = HeroLuna;
		}

		else if (DataGameplaySetup.Hero3Name == "Ginny") {
			Hero3Sprite = HeroGinny;
		}

		// Player 4
		if (DataGameplaySetup.Hero4Name == "Harry") {
			Hero4Sprite = HeroHarry;
		}

		else if (DataGameplaySetup.Hero4Name == "Hermione") {
			Hero4Sprite = HeroHermione;
		}

		else if (DataGameplaySetup.Hero4Name == "Ron") {
			Hero4Sprite = HeroRon;
		}

		else if (DataGameplaySetup.Hero4Name == "Neville") {
			Hero4Sprite = HeroNeville;
		}

		else if (DataGameplaySetup.Hero4Name == "Luna") {
			Hero4Sprite = HeroLuna;
		}

		else if (DataGameplaySetup.Hero4Name == "Ginny") {
			Hero4Sprite = HeroGinny;
		}

		// Player 5
		if (DataGameplaySetup.Hero5Name == "Harry") {
			Hero5Sprite = HeroHarry;
		}

		else if (DataGameplaySetup.Hero5Name == "Hermione") {
			Hero5Sprite = HeroHermione;
		}

		else if (DataGameplaySetup.Hero5Name == "Ron") {
			Hero5Sprite = HeroRon;
		}

		else if (DataGameplaySetup.Hero5Name == "Neville") {
			Hero5Sprite = HeroNeville;
		}

		else if (DataGameplaySetup.Hero5Name == "Luna") {
			Hero5Sprite = HeroLuna;
		}

		else if (DataGameplaySetup.Hero5Name == "Ginny") {
			Hero5Sprite = HeroGinny;
		}

		else {
			Hero5Sprite = HeroHarry;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}