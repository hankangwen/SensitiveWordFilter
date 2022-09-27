using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IllegalWordDetectionTest : MonoBehaviour
{
    public string text;

    private void Start()
    {
        var textAsset = Resources.Load<TextAsset>("MinGanCi");
        Debug.Log(textAsset);
        string[] badWords = textAsset.text.Split('|');
        IllegalWordDetection.Instance.Init(badWords);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(text);
            var value = IllegalWordDetection.Instance.Filter(text);
            Debug.Log(text);
        }
    }
}
