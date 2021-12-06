using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehavior : MonoBehaviour
{
    bool scoreChanged = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnGUI()
    {
        if (scoreChanged)
        {
            Texture2D tRect = new Texture2D(1, 1);
            tRect.SetPixel(1, 1, new Color(0.2F, 0.3F, 0.4F, 1F));
            tRect.Apply(); //Applies all the changes made
            GUI.DrawTexture(new Rect(0, 0, 500, 200), tRect);
            Debug.Log("something supposedly happened here");
            scoreChanged = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
