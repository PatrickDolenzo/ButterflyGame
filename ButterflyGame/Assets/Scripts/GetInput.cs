using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetInput : MonoBehaviour
{

    //Components
    CarMovement carMovement;


    //Awake is called when the script instance is being loaded
    void Awake()
    {
        carMovement = GetComponent<CarMovement>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
         inputVector.x = Input.GetAxis("Horizontal");
         inputVector.y = Input.GetAxis("Jump");



        carMovement.SetInputVector(inputVector);

    }

}