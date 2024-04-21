using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFade : MonoBehaviour
{
    public float speedScale = 1f;
    public Color fadeColor = Color.black;
    // Rather than Lerp or Slerp, we allow adaptability with a configurable curve
    public AnimationCurve Curve = new AnimationCurve(new Keyframe(0, 1),
        new Keyframe(0.5f, 0.5f, -1.5f, -1.5f), new Keyframe(1, 0));
   


    private float alpha = 0f; 
    private Texture2D texture;
    private int direction = 0;
    private float time = 0f;

    private void Start()
    {
        texture = new Texture2D(1, 1);
        texture.SetPixel(0, 0, new Color(fadeColor.r, fadeColor.g, fadeColor.b, alpha));
        texture.Apply();

            alpha = 0f;
            time = 1f;
            direction = -1;
            
    }

    private void Update()
    {

        
        if (alpha >= 1f)
        {
                    alpha = 0f;
                    ColourManager._colour ="";
                    ColourManager._islast = false;
                    Debug.Log("Time's Up!");
                    ColourManager._colour = "";
                    SceneManager.LoadScene("GameOver");

        }
        
    }


    public void OnGUI()
    {
        if (alpha > 0f) GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), texture);
        if (direction != 0)
        {
            time += direction * Time.deltaTime * speedScale;
            alpha = Curve.Evaluate(time);
            texture.SetPixel(0, 0, new Color(fadeColor.r, fadeColor.g, fadeColor.b, alpha));
            texture.Apply();
            if (alpha <= 0f || alpha >= 1f) direction = 0;
        }
    }




}
