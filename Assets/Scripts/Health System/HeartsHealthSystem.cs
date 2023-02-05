using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class HeartsHealthSystem {

	public const int MAX_FRAGMENT_AMOUNT = 4;

	public event EventHandler OnDamage;
	public event EventHandler OnHeal;

	private List<Heart> heartList;
	public HeartsHealthSystem(int heartAmount) {
		heartList = new List<Heart>();
		for (int i = 0; i < heartAmount; i++)
		{
			Heart heart = new Heart(4);
			heartList.Add(heart);
		}
	}

	public List<Heart> GetHeartList() {
		return heartList;
	}

	public void Damage(int damageAmount) {
		
		//Cycle through all hearts starting from the end
		for (int i = heartList.Count - 1; i >= 0; i--) {
			Heart heart = heartList[i];

			// Tests if this heart can absorb damageAmount
			if (damageAmount > heart.GetFragmentAmount()) {
				// Heart cannot absorb full damageAmount, goes to next heart
				damageAmount -= heart.GetFragmentAmount();
				heart.Damage(heart.GetFragmentAmount());
			}
			else {
				// Heart can absorb full damageAmount, absorb and break
				heart.Damage(damageAmount);
				break;
			}
		}

		if (OnDamage != null) OnDamage(this, EventArgs.Empty);
	}

	public void Heal(int healAmount) {
		for (int i = 0; i < heartList.Count; i++) {
			Heart heart = heartList[i];
			int missingFragments = MAX_FRAGMENT_AMOUNT - heart.GetFragmentAmount();
			if (healAmount > missingFragments) {
				healAmount -= missingFragments;
				heart.Heal(missingFragments);
			}
			else {
				heart.Heal(healAmount);
				break;
			}
		}

		if (OnHeal != null) OnHeal(this, EventArgs.Empty);
	}

	// Represents a Single Heart
	public class Heart {

	private int fragments;

		public Heart(int fragments) {
			this.fragments = fragments;
		}
	
		public int GetFragmentAmount() {
			return fragments;
		}

		public void SetFragments(int fragments) {
			this.fragments = fragments;
		}

		public void Damage(int damageAmount)
		{
			if (damageAmount >= fragments) {
				fragments = 0;
			}
			else {
				fragments -= damageAmount;
			}
		}

		public void Heal(int healAmount) {
			if (fragments + healAmount > MAX_FRAGMENT_AMOUNT) {
				fragments = MAX_FRAGMENT_AMOUNT;
			}
			else {
				fragments += healAmount;
			}
		}
	}
}
