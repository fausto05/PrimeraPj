using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAI : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    // Método para recibir daño
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);  // Destruye el enemigo
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si el objeto que colisiona tiene la etiqueta "bala"
        if (collision.gameObject.CompareTag("Bala"))
        {
            TakeDamage(20); // Aplicar todo el daño para destruir el enemigo
        }
    }
}
