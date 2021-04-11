using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static int energy;
    private static int starScore;
    public static event System.Action EnergyDecreased;
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
        
        if(energy <2 )
        {
            GameOver?.Invoke();
            Debug.Log("-- No energy");
        }
        else
        {
            energy -= 1;
            EnergyDecreased?.Invoke();
        }
        
    }

    public void SetEnergy()
    {
        energy = 1;
        Debug.Log("resume energy:"+energy);
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
