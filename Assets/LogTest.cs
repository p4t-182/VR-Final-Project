using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTest : MonoBehaviour
{
    private void OnEnable(){
        AppEventManager.Player.OnHealthChanged += LogHealthChanged;
    }

    private void Disable(){
         AppEventManager.Player.OnHealthChanged -= LogHealthChanged;
    }

    private void LogHealthChanged(Component c, int health){
        Debug.Log(c);
        Debug.Log(health);
    }
   
}
