using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int energy;
    private int starScore;

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
}
