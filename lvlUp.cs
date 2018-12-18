using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlUp : MonoBehaviour {

        
    public int nextLevel = 10; //how much xp till next level
    public int currentLevel = 1; //current level for player
    public int inputxp; //the mumbo jumbo that makes you harder/stronger by beating things to a pulp or whatever


    // Update is called once per frame
    private void Update()
    {
         HUD script = GetComponent<HUD>();
        inputxp = script.xp;
        if (inputxp >= nextLevel)
        {
            script.xp -= nextLevel;
            LevelMePlez();
        }

    }



    public void LevelMePlez()
    {
    nextLevel = (Mathf.FloorToInt(nextLevel * 0.5f)) + nextLevel; // take current level, times it by 0.5 and then add results back to next level. Ex: Floor(10 * 0.5) = 5 + 10 = 15 = nextLevel
        currentLevel++;

    }
}
