using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowProjectile : MonoBehaviour
{
    public float Vitesse = 3.5f;
    private void Update()
    {
        transform.position += -transform.right * Vitesse * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            Destroy(gameObject);
            Debug.Log("Mur");
        }
        if (collision.gameObject.name == "Player2")
        {
            Destroy(gameObject);
            playerController.instance.currentHealth -= 1;
            Debug.Log("Player");
        }

    }
   
}
