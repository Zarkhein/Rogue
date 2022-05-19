using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    
    // Update is called once per frame
    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);  
        
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
