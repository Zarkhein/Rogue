using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Update is called once per frame
    public float offSet;

    public GameObject projectile;
    public Transform shotPoint;
    public static Weapon instance;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public bool skillLearned1 = false;
    public bool skillLearned2 = false; 

    void Update()
    {
        Shot();
    }

    private void Awake()
    {
        instance = this;
    }


    void Shot()
    {
        //traque la souris
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offSet);

        //clock
        if (timeBtwShots <= 0)
        {
            if (Input.GetKey("f"))
            {
                //clone un projectile
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
            if(skillLearned1 == true)
            {
                if (Input.GetKey("m"))
                {
                    StartCoroutine(doubleShot());
                    timeBtwShots = startTimeBtwShots;
                }
            }
            if (skillLearned2 == true && skillLearned1 == true)
            {
                if (Input.GetKey("m"))
                {
                    StartCoroutine(tripleShoot());
                    timeBtwShots = startTimeBtwShots;
                }
            }
            else
            {
                print("Vous n'avais pas la connaissance requise...");
            }
        }
        else
        {
            Debug.Log("Reloading");
            timeBtwShots -= Time.deltaTime;
        }
    }

    IEnumerator doubleShot()
    {
        Instantiate(projectile, shotPoint.position, transform.rotation);
        yield return new WaitForSeconds(.1f);
        Instantiate(projectile, shotPoint.position, transform.rotation);
    }

    IEnumerator tripleShoot()
    {
        Instantiate(projectile, shotPoint.position, transform.rotation);
        yield return new WaitForSeconds(.1f);
        Instantiate(projectile, shotPoint.position, transform.rotation);
        yield return new WaitForSeconds(.1f);
        Instantiate(projectile, shotPoint.position, transform.rotation);
    }


}
