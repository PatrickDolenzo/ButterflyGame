using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, -1.5f, 1.5f), Mathf.Clamp(target.position.y, 0.5f, 134f), transform.position.z);
    }
}





//(target.transform.position.x, target.transform.position.y, transform.position.z);