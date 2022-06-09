using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour
{
    public GameObject skillTree;
    public Button btn_mainSkill, btn_doubleshoot;


    private void Start()
    {
        skillTree.SetActive(false);
        btn_mainSkill.onClick.AddListener(doubleShoot);
        btn_doubleshoot.onClick.AddListener(tripleShoot);
        btn_doubleshoot.interactable = false;
    }

    void tripleShoot()
    {
        Weapon.instance.skillLearned2 = true;
    }

    void debugfunction()
    {
        Debug.Log("le pointer est dans le btn");
    }

    void doubleShoot()
    {
        Weapon.instance.skillLearned1 = true;
        btn_doubleshoot.interactable = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            skillTree.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            skillTree.SetActive(false);
        }
    }
}
