using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static int energy;
    private static int starScore;
    public static event System.Action StarCollected;
    public static event System.Action GameOver;

    [SerializeField]
    GameObject player;

    void Awake()
    {
        energy = 3;
        starScore = 0;
        player.GetComponent<Renderer>().enabled = false;
    }

    public void SetDamage()
    {
        
        if(energy == 0)
        {
            GameOver?.Invoke();
        }
        else
        {
            energy -= 1;
        }
        
    }

    public void SetEnergy()
    {
        energy += 1;
    }

    public void IncreaseStarScore()
    {
        starScore += 1;
        StarCollected?.Invoke();
    }

    public int getStarScore()
    {
        return starScore;
    }
    public int getEnergy()
    {
        return energy;
    }

}
