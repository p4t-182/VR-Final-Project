using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class whack : MonoBehaviour
{
    [SerializeField] private GameObject ground;
    [SerializeField] private AudioClip bonkSound;
    private AudioSource audio;


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collider){
        
        if (collider.gameObject.tag == "Gopher")
        {
            audio.PlayOneShot(bonkSound);
            collider.gameObject.transform.DOScaleX(0.1f, 1f);
            ground.transform.DOShakePosition(1.8f, new Vector3(0.13f, 0, 0), 13, 0, false, false);
            Score.AddScore(2);
            collider.gameObject.transform.DOScaleX(300f, 1f).SetDelay(2f);

        }
        
    }

   
}
