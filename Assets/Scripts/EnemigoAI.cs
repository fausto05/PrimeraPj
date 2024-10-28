using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAI : MonoBehaviour
{
    public GameObject deadBodyPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            GameObject deadBody = Instantiate(deadBodyPrefab, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
