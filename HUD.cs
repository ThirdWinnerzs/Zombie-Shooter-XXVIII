using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Text partDisplay;
    public Text moneyDisplay;
    public Text xpDisplay;
    private int minMoneyGain = 75;
    private int maxMoneyGain = 150;
    private int minXpGain = 1;
    private int maxXpGain = 5;
    public int money = 0;
    public int xp = 0;
    public int parts = 0;
    private void Update()
    {
        moneyDisplay.text = money.ToString();
        xpDisplay.text = xp.ToString();
        partDisplay.text = parts.ToString();
    }
    public void Payday(int inputmoney, int inputxp) //Get updates from Zombie script to update current money and xp
    {
        money += Random.Range(minMoneyGain, maxMoneyGain);
        xp += Random.Range(minXpGain, maxXpGain);
    }
    public void partFound()
    {
        parts ++;
        partDisplay.text = parts.ToString();
        
    }
}
