/*
 * Team Knowledge
 * SP21 Game 2 [Fast Food]
 * Concret health item
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormHealth : Food
{
    public int stamina;
    public int health;
    public override void PrepFood()
    {
        staminaIncrease = stamina;
        healthChange = health;

        //random = Random.Range(1, 3);
        //if (random == 1)
        //{
        //    spawnPoint = new Vector3(-4, 0, 95);
        //}
        //else if (random == 2)
        //{
        //    spawnPoint = new Vector3(0, 0, 95);
        //}
        //else
        //{
        //    spawnPoint = new Vector3(4, 0, 95);
        //}
        //transform.position = new Vector3(spawnPoint.x, .75f, spawnPoint.z);

        // transform.localScale = new Vector3(transform.localScale.x, 1.5f, transform.localScale.z);

    }
}
