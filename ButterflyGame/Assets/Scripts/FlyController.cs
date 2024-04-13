using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [Header("Car settings")]
    public float driftFactor= 0.95f;
    public float accelerationFactor = 10.0f;
    public float turnFactor = 3.5f;
    public float maxSpeed = 20;


    //Local variables
    float accelerationInput = 0;
    float steeringInput = 0;

    float rotationAngle = 0;
    float velocityVsUp = 0;


    //Components
    Rigidbody2D carRigidbody2D;

    // Awake is called when the script instance in being loaded
    void Awake ()
    {
        carRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Frame-rate independent for physics calcs
    void FixedUpdate()
    {
        ApplyEngineForce();

        ApplySteering();

    }

    void ApplyEngineForce()
    {
        // Calc how much "forward" we are going in terms of the direction of our velocity
        velocityVsUp = Vector2.Dot(transform.up, carRigidbody2D.velocity);

        // Limit so we cannot go faster than the max speed "foward"
        if (velocityVsUp > maxSpeed && accelerationInput > 0)
            return;


        //Limit so cannot go faster than 50% of max speed reverse
            if (velocityVsUp < -maxSpeed * 0.5f && accelerationInput < 0)
         return;

        //Limit so we cannot go faster in any direction while accelerating
        if (carRigidbody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
            return;

        // Apply Drag if there is on accelInput so the car stops when the player lets go      !!!! Dont know if need in final
        if (accelerationInput == 0)
            carRigidbody2D.drag = Mathf.Lerp(carRigidbody2D.drag, 3.0f, Time.fixedDeltaTime * 3);
        else carRigidbody2D.drag = 0;

        // Create a force for the engine
        Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

        //Apply force and pushes the car forward
        carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
    }

    void ApplySteering()
    {
        // Update the rotation angle based on input
        rotationAngle -= steeringInput * turnFactor;

        // Apply steering by rotation the car object
        carRigidbody2D.MoveRotation(rotationAngle);
    }

    public void SetInputVector(Vector2 inputVector)
    {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }


    public float GetVelocityMagnitude()
 {
      return carRigidbody2D.velocity.magnitude;
 } 

}