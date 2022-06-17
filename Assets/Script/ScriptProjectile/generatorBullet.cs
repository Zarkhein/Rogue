using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorBullet : MonoBehaviour
{
    public GameObject bullet;
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnBullet());
        
    }

    // Update is called once per frame
    void Update()
    {
               
        
    }

    


    IEnumerator spawnBullet()
    {
        for (int i = 0; i < 999; i++)
        {
            Instantiate(bullet, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+0.20f, 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }


}
