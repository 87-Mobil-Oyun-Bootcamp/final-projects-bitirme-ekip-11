using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIEnergy : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI energyText;
    int energy = 0;

    UIPanelController panelController;
    GameObject panelObj;


    void Awake()
    {
        UIPanelController.GetEnergy += ShowEnergy;
        panelObj = GameObject.Find("UIPanel");
        panelController = panelObj.GetComponent<UIPanelController>();
    }


    void ShowEnergy()
    {
        energy = panelController.getPlayerEnergy();
        energyText.SetText(energy.ToString());
    }
    

}
