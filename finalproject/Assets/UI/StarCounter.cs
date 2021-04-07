using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarCounter : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI starScore;

    UIPanelController panelController;
    GameObject panelObj;
    private int score = 0;

    void Awake()
    {
        UIPanelController.GetStarScore += ShowScore;
        panelObj = GameObject.Find("UIPanel");
        panelController = panelObj.GetComponent<UIPanelController>();
    }


    void ShowScore()
    {
        score = panelController.getStarScore();
        starScore.SetText(score.ToString());
    }

    /*Player player;
    GameObject playerObj;
    private int score;

    void Awake()
    {
        Player.StarCollected += OnStarCollected;
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();
    }


    void OnStarCollected()
    {
        score = player.getStarScore();
        Debug.Log("star counter : ");
        Debug.Log(score.ToString());
        starScore.SetText(score.ToString());
    }
    
    */

}
