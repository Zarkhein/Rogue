using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossEnemy : MonoBehaviour
{
    public float currentLife = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "fireball(Clone)")
        {
            currentLife -= playerController.instance.damage;
            if(currentLife <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
