using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptIa : MonoBehaviour
{
    public GameObject prefab;
    public Transform shotPoint;
    private float timeBtwShots;
    public float startTimeBtwShots;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Deplacement();
        Shoot();
    }

    private void Shoot()
    {
        //clock
        if (timeBtwShots <= 0)
        {
            //clone un projectile
            Instantiate(prefab, shotPoint.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            Debug.Log("Reloading");
            timeBtwShots -= Time.deltaTime;
        }
    }

    private void Deplacement()
    {
         transform.Translate(Vector2.left * Time.deltaTime);
    }
}
