using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptWave : MonoBehaviour
{
    public Transform posShop, posShop2;
    public int totemLive;
    public GameObject prefab, prefab2;
    public static scriptWave instance;


    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (totemLive == 6)
        {
            Debug.Log("Le spawn est la");
            Instantiate(prefab, posShop.position, transform.rotation);
            Instantiate(prefab2, posShop2.position, transform.rotation);
            totemLive = -1;
        }
        if(totemLive == -7)
        {
            Instantiate(prefab, posShop.position, transform.rotation);
            totemLive = -1;

        }
    }
}
