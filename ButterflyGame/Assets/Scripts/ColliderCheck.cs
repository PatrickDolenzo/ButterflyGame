using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderCheck : MonoBehaviour
{

    //Components
    public string _newcolour;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("We just collided" + _newcolour);

        ColourManager._colour += _newcolour;

        SceneManager.LoadScene("TestColour2");
    }

}
