using UnityEngine;
using UnityEngine.EventSystems;// Required when using Event data.
using UnityEngine.UI;

public class testScriptButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button btn;
    public Text txt;
    public GameObject infoSkillText;
    // Start is called before the first frame update

    //TxtSkill
    public string txtInfoSkill;

    public void Start()
    {
        infoSkillText.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(btn.interactable == true)
        {
            infoSkillText.SetActive (true);
            print("Bonjour pointer");
            txt.text = txtInfoSkill;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        infoSkillText.SetActive(false);
        txt.text = "";
        print("Aurevoir pointer");
    }
    
    

}
