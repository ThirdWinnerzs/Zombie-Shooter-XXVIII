using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Text partDisplay;
    public Text moneyDisplay;
    public Text xpDisplay;
    public Text levelDisplay;
    public Text nextLevelDisplay;
    public Text killDisplay;
    public int money = 0;
    public int xp = 0;
    public int parts = 0;
    public int kills = 0;

    private void Update()
    {
        lvlUp script = GetComponent<lvlUp>();
        moneyDisplay.text = money.ToString();
        xpDisplay.text = xp.ToString();
        partDisplay.text = parts.ToString();
        levelDisplay.text = script.currentLevel.ToString();
        nextLevelDisplay.text = (script.nextLevel - xp).ToString() + " (" + script.nextLevel +")";
        killDisplay.text = kills.ToString();
    }
    public void Payday(int inputmoney, int inputxp) //Get updates from Zombie script to update current money and xp
    {
        kills++;
        money += inputmoney;
        xp += inputxp;
        moneyDisplay.text = money.ToString();
        xpDisplay.text = xp.ToString();
        //money += Random.Range(minMoneyGain, maxMoneyGain);
        // xp += Random.Range(minXpGain, maxXpGain);

    }
    public void partFound()
    {
        parts ++;
        partDisplay.text = parts.ToString();
        
    }

}
