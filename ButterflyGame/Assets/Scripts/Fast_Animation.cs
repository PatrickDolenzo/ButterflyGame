using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast_Animation : MonoBehaviour
{

    public Animator _animation;

    // Update is called once per frame
    void Update()
    {
        speed();
    }


    void speed()
    {
        if (Input.GetKeyDown("space"))
        {
            _animation.speed = 10f;
        }
    }


}
