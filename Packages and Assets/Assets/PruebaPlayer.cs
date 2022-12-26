using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaPlayer : MonoBehaviour
{

	public int maxHealth = 100;
	public int currentHealth;

	public PruebaBar pruebaa;

    void Start()
    {
		currentHealth = maxHealth;
		pruebaa.SetMaxHealth(maxHealth);
    }

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}
    }

	void TakeDamage(int damage)
	{
		currentHealth -= damage;

		pruebaa.SetHealth(currentHealth);
	}
}