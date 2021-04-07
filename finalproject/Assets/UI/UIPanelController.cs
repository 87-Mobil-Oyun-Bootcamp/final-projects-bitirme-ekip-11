using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanelController : MonoBehaviour
{
    Player player;
    GameObject playerObj;
    private int energy = 0;
    private int score = 0;
    public static event System.Action GetEnergy;
    public static event System.Action GetStarScore;

    void Awake()
    {
        Player.StarCollected += IncreaseScore;
        Player.EnergyDecreased += DecreaseEnergy;
        playerObj = GameObject.Find("Player");
        player = playerObj.GetComponent<Player>();
    }

    void IncreaseScore()
    {
        GetStarScore?.Invoke();
    }

    void DecreaseEnergy()
    {
        GetEnergy?.Invoke();
    }

    public int getPlayerEnergy()
    {
        energy = player.getEnergy();
        return energy;
    }

    public int getStarScore()
    {
        score = player.getStarScore();
        return score;
    }
}
