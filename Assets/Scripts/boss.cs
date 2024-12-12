using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.XR.Interaction.Toolkit;

public class boss : MonoBehaviour
{
   
    [SerializeField] private AudioClip bonkSound;
    [SerializeField] private XRBaseController controller;

     [SerializeField] private ParticleSystem explosion;
    [SerializeField] private ParticleSystem flash;
    private AudioSource audio;


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col){
        
        

            if(col.gameObject.tag == "LeftHandHammer"){
                controller.SendHapticImpulse(0.7f, 2f);
                audio.PlayOneShot(bonkSound);
                transform.DOScaleZ(0.3f, 1f);
                Score.AddScore(Score.score*2);
                transform.DOScaleZ(300f, 1f).SetDelay(1f);
                explosion.Play();
                flash.Play();

            }else if(col.gameObject.tag == "RightHandHammer"){
                controller.SendHapticImpulse(0.7f, 2f);
                audio.PlayOneShot(bonkSound);
                transform.DOScaleZ(-0.3f, 1f);
                 Score.AddScore(Score.score*2);
                 transform.DOScaleZ(300f, 1f).SetDelay(1f);
                 explosion.Play();
                flash.Play();
            }
            
            

        
        
    }

   
}
