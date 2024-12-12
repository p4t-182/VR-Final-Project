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
                transform.DOScaleZ(0.1f, 1f);
                transform.DOShakePosition(1.8f, new Vector3(0.13f, 0, 0), 13, 0, false, false);
                Score.AddScore(Mathf.FloorToInt(Score.score*1.02f));
                transform.DOScaleZ(300f, 1f).SetDelay(1f);
                explosion.Play();
                flash.Play();

            }else if(col.gameObject.tag == "RightHandHammer"){
                controller.SendHapticImpulse(0.7f, 2f);
                audio.PlayOneShot(bonkSound);
                transform.DOScaleZ(0.1f, 1f);
                transform.DOShakePosition(1.8f, new Vector3(0.13f, 0, 0), 13, 0, false, false);
                Score.AddScore(Mathf.FloorToInt(Score.score*1.02f));
                transform.DOScaleZ(300f, 1f).SetDelay(1f);
                 explosion.Play();
                flash.Play();
            }
            
            

        
        
    }

   
}
