using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allPotionsTime : MonoBehaviour
{
    [Header("Effet")]
    public int effectPotion;
    public float vitesse;
    [Header("Durée")]
    public float timeEffect;
    public float healthIncreasePerSecond;


    private bool TimerStarted = false;
    private bool checkSpeed;
    private bool TimerStarted2 = false;

    private float tickTimer = 0f;
    private const float tick_timer_max = 1f;
    private int tick = 0;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            switch (effectPotion)
            {
                //effet de heal
                case 1:
                    Debug.Log("Debut de l'effet de soin");
                    if (!TimerStarted2) TimerStarted2 = true;

                    break;
                //effet de speed
                case 2:
                    //playerController.instance.moveSpeed += 10;
                    Debug.Log("Debut de l'effet");
                    if (!TimerStarted) TimerStarted = true;
                    if(TimerStarted == true && checkSpeed == false)
                    {
                        playerController.instance.moveSpeed += vitesse;
                        checkSpeed = true;
                    }

                    break;
                default:
                    break;
            }
        }
    }

    void playerHeal()
    {
        if (TimerStarted2)
        {
            tickTimer += Time.deltaTime;
            if (tickTimer >= tick_timer_max)
            {
                tickTimer -= tick_timer_max;
                tick++;
                playerController.instance.currentHealth += healthIncreasePerSecond;
                if(playerController.instance.currentHealth >= playerController.instance.maxHealth)
                {
                    Debug.Log("Vous avez la vie au max");
                    playerController.instance.currentHealth = playerController.instance.maxHealth;
                }
                if (tick == timeEffect)
                {
                    TimerStarted2 = false;
                    checkSpeed = false;
                    Debug.Log("Stop");
                    Destroy(gameObject);
                    
                }
            }
        }
    }

    private float _timer;
    void PlayerSpeed()
    {
        
        if (TimerStarted)
        {
            
            _timer += Time.deltaTime;
            if (_timer >= timeEffect)
            {
                Debug.Log("Test et fin");
                playerController.instance.moveSpeed -= vitesse;
                Destroy(gameObject);
            }
        }
    }

    void Update()
    {
        PlayerSpeed();
        playerHeal();
    }
}
