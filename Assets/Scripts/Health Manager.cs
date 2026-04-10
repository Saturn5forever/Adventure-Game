using TMPro;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float maxHealth = 100f;
    public float health;

    public TextMeshProUGUI healthtext;
    public TextMeshProUGUI deathText;

    void Start()
    {
        health = maxHealth;
        healthtext.text = maxHealth.ToString();
        deathText.text = "";
    }

    void Update()
    {
        
        if(gameObject != null)
        {
            if(health <= 0f)
            {
                deathText.text = "You Died";
                Destroy(gameObject);
            }
        }
        
    }

    public void TakeDamage(float damage)
    {
        Debug.Log("Taking Damage");
        health -= damage;
        UpdateHealthUI();
    }

    public void Heal(float healing)
    {
        Debug.Log("Healing");
        health += healing;
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        healthtext.text = health.ToString();
    }
}
