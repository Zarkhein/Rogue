using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour
{
    public Transform spawnTp;
    public float offSet;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if(collision.gameObject.name == "Player")
        {
            playerController.instance.transform.position = spawnTp.position;
        }
    }
}
