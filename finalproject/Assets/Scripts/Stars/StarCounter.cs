using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarCounter : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI starScore;

    Player player;
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
        starScore.SetText(score.ToString());
    }
}
