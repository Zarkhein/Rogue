using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totemLaunchOffset : MonoBehaviour
{

    public Transform player;
    public float offSet;

    [Header("Weapon")]
    [SerializeField]
    public GameObject prefab;
    public float startTimeBtwShots;
    private float timeBtwShots;
    public Transform shotPoint;
    // Update is called once per frame
    void Update()
    {
        Vector3 difference = player.position - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offSet);
        Shoot();
    }

    private void Shoot()
    {
        if (timeBtwShots <= 0)
        {
            Instantiate(prefab, shotPoint.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }
}
