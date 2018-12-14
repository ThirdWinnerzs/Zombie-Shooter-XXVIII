using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

    public int maxHitPoints = 100;
    private int currentHealth;
    private int minMoneyGain = 75;
    private int maxMoneyGain = 150;
    private int minXpGain = 1;
    private int maxXpGain = 5;
    public int money = 0;
    public int xp = 0;
    // Use this for initialization
    void Start()
    {
        currentHealth = maxHitPoints;

    }
    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    //The character has been hurt by something so apply the damage.
    public void ApplyThings(int amount)
    {
        currentHealth -= amount;
    }

    public void Die()
    {
        Destroy(gameObject);

        //When zombie dies gave out xp & money to HUD script
        HUD script = GetComponent<HUD>();
        if (script != null)
        {
            money = (Random.Range(minMoneyGain, maxMoneyGain));
            xp = (Random.Range(minMoneyGain, maxMoneyGain));
            script.Payday(money, xp);
        }
    }
}
