using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourManager : MonoBehaviour
{
    public static string _colour = "";

    public static ColourManager Instance;

    public static bool _islast = false; 

    public GameObject _butterfly_bottom;

    public GameObject _butterfly_top;

    public RuntimeAnimatorController _blue;

    public RuntimeAnimatorController _red;

    public RuntimeAnimatorController _yellow;

    SpriteRenderer top_wings;

    Color wing_colour;

    float m_red, m_blue, m_green;

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

        Animator animator = _butterfly_bottom.GetComponent<Animator>();

        top_wings = _butterfly_top.GetComponent<SpriteRenderer>();

        switch (_colour)
        {
            case "Yellow":
                animator.runtimeAnimatorController = _yellow;
                _islast = true;
                Debug.Log("The Colour is " + _colour);
                break;
            case "Blue":
                
                animator.runtimeAnimatorController = _blue;
                _islast = true;
                Debug.Log("The Colour is " + _colour);
                break;
            case "Red":
            animator.runtimeAnimatorController = _red;
            _islast = true;
                Debug.Log("The Colour is " + _colour);
                break;
            case "RedRed":

            
                Debug.Log("The Colour is " + _colour);
                break;
            case "BlueBlue":
                top_wings.color = Color.green;
                animator.runtimeAnimatorController = _blue;
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
