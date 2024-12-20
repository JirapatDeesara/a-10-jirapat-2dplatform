﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

	public Slider healthSlider;
	public Gradient gradient;
	public Image fill;

	public void SetMaxHealth(int health)
	{
		healthSlider.maxValue = health;
		healthSlider.value = health;

		//fill.color = gradient.Evaluate(1f);
		Debug.Log($"Health Slider: {healthSlider.value} / {healthSlider.maxValue}");
	}

    public void SetHealth(int health)
	{
		healthSlider.value = health;

		//fill.color = gradient.Evaluate(healthSlider.normalizedValue);
	}

}
