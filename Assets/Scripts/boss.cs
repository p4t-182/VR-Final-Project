using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class boss : MonoBehaviour
{
   
    [SerializeField] private AudioClip bonkSound;
    private AudioSource audio;


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col){
        
        

            if(col.gameObject.tag == "LeftHandHammer"){
                audio.PlayOneShot(bonkSound);
                transform.DOScaleZ(0.3f, 1f);
                Score.AddScore(Score.score*2);
                transform.DOScaleZ(300f, 1f).SetDelay(1f);

            }else if(col.gameObject.tag == "RightHandHammer"){
                 
                 audio.PlayOneShot(bonkSound);
                 transform.DOScaleZ(-0.3f, 1f);
                 Score.AddScore(Score.score*2);
                 transform.DOScaleZ(300f, 1f).SetDelay(1f);
            }
            
            

        
        
    }

   
}
