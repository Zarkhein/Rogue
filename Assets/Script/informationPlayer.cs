using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class informationPlayer : MonoBehaviour
{
    public GameObject playerInformation;
    private bool information;
    private float timeBtwOpen;
    private float startTimeBtwOpen = 1f;

    public Text lifeStats, speedStats, forceStats, moneyStats;
    // Start is called before the first frame update
    void Start()
    {
        information = false;
        playerInformation.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        openPlayerGUI();
        lifeStats.text = playerController.instance.currentHealth.ToString() + "/" + playerController.instance.maxHealth.ToString();
        speedStats.text = playerController.instance.moveSpeed.ToString();
        forceStats.text = playerController.instance.damage.ToString();
        moneyStats.text = playerController.instance.moneyPlayer.ToString();
    }
    private void FixedUpdate()
    {
               
    }

    private void openPlayerGUI()
    {        
        if (Input.GetKey("i"))
        {
            playerInformation.SetActive(true);
            
        }
        if (Input.GetKey("p"))
        {
            playerInformation.SetActive(false);
        }

    }
}
