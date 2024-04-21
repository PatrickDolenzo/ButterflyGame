using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderCheck : MonoBehaviour
{

    //Components
    public string _newcolour;

    public AudioSource _hitsound;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(waiter());
    }

IEnumerator waiter()
{
        Debug.Log("We just collided" + _newcolour);

        _hitsound.Play();

         yield return new WaitForSeconds (1);

        ColourManager._colour += _newcolour;

        if (ColourManager._islast == false)
        {
        SceneManager.LoadScene("TestColour2");
        }
        else
        {
         SceneManager.LoadScene("Scrolling");
        }



}



}
