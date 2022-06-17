using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dashPlayer : MonoBehaviour
{
    public bool dashSkill = false;
    public static dashPlayer instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skillDash();
        
    }

    private void Awake()
    {
        instance = this;
    }

    void skillDash()
    {
        if (Input.GetKeyDown("v") && dashSkill == true)
        {
            StartCoroutine(Dash());
        }
        else
        {
            Debug.Log("Vous n'avez pas la compétence requise...");
        }
    }

    IEnumerator Dash()
    {
        playerController.instance.moveSpeed += 500;
        yield return new WaitForSeconds(0.2f);
        playerController.instance.moveSpeed -= 500;
    }
}
