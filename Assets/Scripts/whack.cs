using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.XR.Interaction.Toolkit;

public class whack : MonoBehaviour
{
    [SerializeField] private GameObject ground;
    [SerializeField] private AudioClip bonkSound;
    private AudioSource audio;
    [SerializeField] private XRBaseController controller;


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider){

        if (collider.gameObject.tag == "MainHammer")
        {
            audio.PlayOneShot(bonkSound);
            controller.SendHapticImpulse(0.7f, 2f);
            transform.DOScaleX(0.1f, 1f);
            ground.transform.DOShakePosition(1.8f, new Vector3(0.13f, 0, 0), 13, 0, false, false);
            Score.AddScore(2);
            transform.DOScaleX(300f, 1f).SetDelay(2f);

        }
        
    }

   
}
