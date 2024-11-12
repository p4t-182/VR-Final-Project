using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // change according to our game

    public int hp = 10;
    private float hitTimer = 1f;
   

    // Update is called once per frame
    void Update()
    {
        hitTimer -= Time.deltaTime;

        if (hitTimer <= 0){
            hitTimer = 1f;
            hp -= 1;
            AppEventManager.Player.OnHealthChanged.Invoke(this, hp);

        }
        
    }
}
