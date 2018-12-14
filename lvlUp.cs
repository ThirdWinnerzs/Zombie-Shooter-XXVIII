using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlUp : MonoBehaviour {

        /*other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);*/
         // HUD script = GetComponent<HUD>();
    public int nextLevel = 10; //how much xp till next level
    public int currentLevel = 1; //current level for player
    public int xp; //the mumbo jumbo that makes you harder/stronger by beating things to a pulp or whatever
   

    // Update is called once per frame
    void Update () {
      

	}

    public void LevelMePlez()
    {
    nextLevel = (Mathf.FloorToInt(nextLevel * 0.5f)) + nextLevel; // take current level, times it by 0.5 and then add results back to next level. Ex: Floor(10 * 0.5) = 5 + 10 = 15 = nextLevel


    }
}
