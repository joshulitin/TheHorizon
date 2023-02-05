using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey;
using CodeMonkey.Utils;

public class HeartsHealthVisual : MonoBehaviour {

	[SerializeField] private Sprite heartSprite0;
	[SerializeField] private Sprite heartSprite1;
	[SerializeField] private Sprite heartSprite2;
	[SerializeField] private Sprite heartSprite3;
	[SerializeField] private Sprite heartSprite4;

	private List<HeartImage> heartImageList;
	private HeartsHealthSystem heartsHealthSystem;

	private bool isHealing;

	private void Awake()
	{
		heartImageList = new List<HeartImage>();
	}
	private void Start()
	{
		FunctionPeriodic.Create(HealingAnimatedPeriodic, .05f);
		HeartsHealthSystem heartsHealthSystem = new HeartsHealthSystem(4);
		SetHeartsHealthSystem(heartsHealthSystem);
/*
		CMDebug.ButtonUI(new Vector2(-50, -100), "Damage 1", () => heartsHealthSystem.Damage(1));
		CMDebug.ButtonUI(new Vector2(50, -100), "Damage 4", () => heartsHealthSystem.Damage(4));

		CMDebug.ButtonUI(new Vector2(-50, -200), "Heal 1", () => heartsHealthSystem.Heal(1));
		CMDebug.ButtonUI(new Vector2(50, -200), "Heal 4", () => heartsHealthSystem.Heal(4));
		*/
	}

	public void SetHeartsHealthSystem(HeartsHealthSystem heartsHealthSystem) {
		this.heartsHealthSystem = heartsHealthSystem;

		List<HeartsHealthSystem.Heart> heartList = heartsHealthSystem.GetHeartList();
		Vector2 heartAnchoredPosition = new Vector2(0, 0);
		for (int i = 0; i < heartList.Count; i++) {
			HeartsHealthSystem.Heart heart = heartList[i];
			CreateHeartImage(heartAnchoredPosition).SetHeartFragments(heart.GetFragmentAmount());
			heartAnchoredPosition += new Vector2(35, 0);
		}

		heartsHealthSystem.OnDamage += HeartsHealthSystem_OnDamage;
		heartsHealthSystem.OnHeal += HeartsHealthSystem_OnHeal;
	}

	private void HeartsHealthSystem_OnHeal(object sender, EventArgs e) {
		// Hearts Health System was Healed
		//RefreshAllHearts();
		isHealing = true;
	}

	private void HeartsHealthSystem_OnDamage(object sender, System.EventArgs e) {
		// Hearts Health System was Damaged
		RefreshAllHearts();
	}

	private void RefreshAllHearts()
	{
		List<HeartsHealthSystem.Heart> heartList = heartsHealthSystem.GetHeartList();

		for (int i = 0; i < heartImageList.Count; i++)
		{
			HeartImage heartImage = heartImageList[i];
			HeartsHealthSystem.Heart heart = heartList[i];
			heartImage.SetHeartFragments(heart.GetFragmentAmount());
		}
	}

	private void HealingAnimatedPeriodic() {
		if (isHealing) {
		bool fullyHealed = true;
		List<HeartsHealthSystem.Heart> heartList = heartsHealthSystem.GetHeartList();
		for (int i = 0; i < heartList.Count; i++) {
			HeartImage heartImage = heartImageList[i];
			HeartsHealthSystem.Heart heart = heartList[i];
			if (heartImage.GetFragmentAmount() != heart.GetFragmentAmount())
			{
				// Visual is different from logic
				heartImage.AddHeartVisualFragment();
				fullyHealed = false;
				break;
				}
			}
			if (fullyHealed) {
				isHealing = false;
			}
		}
	}
	private HeartImage CreateHeartImage(Vector2 anchoredPosition)
	{
		// Creates Game Object
		GameObject heartGameObject = new GameObject("Heart", typeof(Image));

		//Set as child of this transform
		heartGameObject.transform.parent = transform;
		heartGameObject.transform.localPosition = Vector3.zero;

		// Locate and Size heart
		heartGameObject.GetComponent<RectTransform>().anchoredPosition = anchoredPosition;
		heartGameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);

		// Set Heart Sprite
		Image heartImageUI = heartGameObject.GetComponent<Image>();
		heartImageUI.sprite = heartSprite0;

		HeartImage heartImage = new HeartImage(this, heartImageUI);
		heartImageList.Add(heartImage);
		return heartImage;
	}
	
	
	// Represent a Single Hearat
	public class HeartImage {

		private int fragments;
		private Image heartImage;
		private HeartsHealthVisual heartsHealthVisual;

		public HeartImage(HeartsHealthVisual heartsHealthVisual, Image heartImage) {
			this.heartsHealthVisual = heartsHealthVisual;
			this.heartImage = heartImage;
		}

		public void SetHeartFragments(int fragments) {

			this.fragments = fragments;

			switch (fragments)
			{
				case 0: heartImage.sprite = heartsHealthVisual.heartSprite0; break;
				case 1: heartImage.sprite = heartsHealthVisual.heartSprite1; break;
				case 2: heartImage.sprite = heartsHealthVisual.heartSprite2; break;
				case 3: heartImage.sprite = heartsHealthVisual.heartSprite3; break;
				case 4: heartImage.sprite = heartsHealthVisual.heartSprite4; break;
			}
		}

		public int GetFragmentAmount() {
			return fragments;
		}

		public void AddHeartVisualFragment() {
			SetHeartFragments(fragments + 1);
		}
	}
}
