using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static int energy;
    private static int starScore;

    // Start is called before the first frame update
    void Awake()
    {
        energy = 3;
        starScore = 0;
    }

    public void SetDamage()
    {
        energy -= 1;
    }

    public void IncreaseStarScore()
    {
        starScore += 1;
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
