using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourManager : MonoBehaviour
{
    public static string _colour = "";

    public static ColourManager Instance;

    public Sprite Yellow;

    public Sprite Blue;

    // Start is called before the first frame update
    void Start()
    {
        CheckColour();

    }

    // Update is called once per frame
    void Update()
    {
        
        


    }


    void CheckColour()
    {

        switch (_colour)
        {
            case "Yellow":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Yellow;
                Debug.Log("The Colour is " + _colour);
                break;
            case "Blue":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Blue;
                Debug.Log("The Colour is " + _colour);
                break;




            case "YellowYellow":
                Debug.Log("The Colour is " + _colour);
                break;

            default:
                Debug.Log("This is default");
                Debug.Log("The Colour is " + _colour);
            break;

        }


    }



}
