using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class AppEventManager {

    public static readonly PlayerEvents Player = new PlayerEvents();
    public static readonly UIEvents uI = new UIEvents();

    public class PlayerEvents{
        public UnityAction<Component, int> OnHealthChanged;
    }

    public class UIEvents {
        public UnityAction<int> OnButtonPress;
        
    }
}
   
