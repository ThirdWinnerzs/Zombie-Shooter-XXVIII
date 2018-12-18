using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {
   public GameObject player;
    public float currentHealth;
    public int minMoneyGain = 75;
    public int maxMoneyGain = 150;
    public int minXpGain = 1;
    public int maxXpGain = 5;
    private int inputmoney = 0;
    private int inputxp = 0;

    // Update is called once per frame
    void fixedUpdate()
    {
            vp_DamageHandler healthscript = GetComponent<vp_DamageHandler>();
        if (healthscript.CurrentHealth == 0)
        {
            Die();
        }
    }
    public void Die()
    {
        //When zombie dies gave out xp & money to HUD script
        inputmoney = Random.Range(minMoneyGain, maxMoneyGain);
        inputxp = Random.Range(minXpGain, maxXpGain);

        HUD script = player.GetComponent<HUD>();
        script.Payday(inputmoney, inputxp);  
    }   
}

