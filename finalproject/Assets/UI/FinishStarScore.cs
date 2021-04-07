using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishStarScore : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI starScore;

    Player player;
    GameObject playerObj;
    private int score;

    void Awake()
    {
        GameManager.showTotalScore += OnStarCollected;
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();
    }


    void OnStarCollected()
    {
        Debug.Log("over 2");
        score = player.getStarScore();
        starScore.SetText(score.ToString());

    }
}
