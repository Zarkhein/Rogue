using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour
{
    public Image imgBtn;
    // Start is called before the first frame update
    public void changeColor()
    {
        imgBtn.GetComponent<Image>().color = Color.red;
    }
}
