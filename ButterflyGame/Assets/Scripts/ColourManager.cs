using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourManager : MonoBehaviour
{
    public static string _colour = "";

    public static ColourManager Instance;

    public static bool _islast = false; 

    public Sprite Yellow;

    public Sprite Blue;

    public Sprite Green;

    public Sprite Red;

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
                _islast = true;
                Debug.Log("The Colour is " + _colour);
                break;
            case "Blue":
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Blue;
                _islast = true;
                Debug.Log("The Colour is " + _colour);
                break;
            case "Green":
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Green;
            _islast = true;
                Debug.Log("The Colour is " + _colour);
                break;
            case "Red":
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Red;
            _islast = true;
                Debug.Log("The Colour is " + _colour);
                break;
            case "GreenGreen":

            
                Debug.Log("The Colour is " + _colour);
                break;
            case "RedRed":

            
                Debug.Log("The Colour is " + _colour);
                break;
            case "BlueBlue":

            
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
