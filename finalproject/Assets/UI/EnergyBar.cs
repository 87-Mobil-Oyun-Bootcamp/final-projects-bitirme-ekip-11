using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider slider;

    UIPanelController panelController;
    GameObject panelObj;
    private int energy;
    public Gradient gradient;
    public Image fill;

    void Awake()
    {
        slider.value = 3;
        fill.color = gradient.Evaluate(1f);
        UIPanelController.GetEnergy += ShowEnergy;
        panelObj = GameObject.Find("UIPanel");
        panelController = panelObj.GetComponent<UIPanelController>();
    }


    void ShowEnergy()
    {
        energy = panelController.getPlayerEnergy();
        Debug.Log("energy "+energy.ToString());
        slider.value = energy;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    
}
