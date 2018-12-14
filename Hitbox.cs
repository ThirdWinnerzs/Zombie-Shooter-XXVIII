using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour {  
    private int minDamage = 10;
    private int maxDamage = 20;

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Zombie"))
        {
            Zombie script = GetComponent<Zombie>();
                if (script != null)
                {
                     script.ApplyThings(Random.Range(minDamage, maxDamage));
                }
        }
    }
}

