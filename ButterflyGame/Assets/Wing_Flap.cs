using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing_Flap : MonoBehaviour
{

    public AudioSource _flapsound;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(waiter());
    }

IEnumerator waiter()
{
        
        for (int i = 0; i < 60; i++) 
        {
        _flapsound.Play();

         yield return new WaitForSeconds (1);
        }



}


}
