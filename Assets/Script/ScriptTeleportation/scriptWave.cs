using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptWave : MonoBehaviour
{
    public Transform posShop;
    public int totemLive;
    public GameObject prefab;
    public static scriptWave instance;


    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (totemLive == 0)
        {
            Debug.Log("Le spawn est la");
            Instantiate(prefab, posShop.position, transform.rotation);
            
            totemLive = -1;
        }
        
    }
}
