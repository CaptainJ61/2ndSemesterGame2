/*
 * Team Knowledge
 * SP21 Game 2 [Fast Food]
 * Stamina bar for player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider staminaBar;
    public float staminaModifier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        staminaBar.value -= Time.deltaTime * staminaModifier;
        if (staminaBar.value == 0)
        {
            Debug.Log("Game Over");
            GameManager.instance.GameOver();
        }
    }

    public void SmallEnergyRestore()
    {
        staminaBar.value += 10;
    }

    public void LargeEnergyRestore()
    {
        staminaBar.value += 20;
    }
    public void ChangeStaminaBar(int value)
    {
        staminaBar.value += value;
    }

}
