using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileBehavior : MonoBehaviour
{

    [Header("Vitesse")]
    public float vitesseY;
    public float vitesseX;
    private int lifeTime = 5;




    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(vitesseY, vitesseX, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Hit le player");
            playerController.instance.currentHealth -= 1;
        }
    }
    void DestroyProjectile()
    {
        if(gameObject.name == "fire(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
