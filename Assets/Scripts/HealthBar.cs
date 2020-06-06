using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public HealthBar healthbar;
    public Slider healthBar;
    public int maxHealth = 100;
    public int currentHealth;
    public int damage = 20;
    public Gradient gradient;
    public Image fill;
    public GameObject loseScreen;

    private void Start()
    {
        currentHealth = maxHealth;
        healthbar.setMaxHealth(maxHealth);
        fill.color = gradient.Evaluate(1f);
    }


    public void setMaxHealth(int health)
    {
        healthBar.maxValue = health;
        healthBar.value = health;
    }
   

    public void SetHealth(int health)
    {
        healthBar.value = health;

    }

    public void TakeDamage()
    {
        if (currentHealth > 0)
        {
            currentHealth -= damage;
            healthbar.SetHealth(currentHealth);
            fill.color = gradient.Evaluate(healthBar.normalizedValue);
        }
    }

    private void Update()
    {
        if (currentHealth == 0)
        {
            loseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
