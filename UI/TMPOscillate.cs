using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TMPOscillate : MonoBehaviour
{
    public float period = 0.01f;
    public float intensityMovement = 0.05f;
    
    private float minValueToOscillate = 0.2f;
    private float maxValueToOscillate = 1f;
    private TextMeshProUGUI _textMeshProUGUI;
    private bool _increasing = false;
    private float nextActionTime = 0.0f;


    void Start()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    void FixedUpdate()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
        
            if (!_increasing)
            {
                _textMeshProUGUI.alpha -= intensityMovement;
                if (_textMeshProUGUI.alpha <= minValueToOscillate)
                {
                    _increasing = true;
                }
            }
            else
            {
                _textMeshProUGUI.alpha += intensityMovement;
                if (_textMeshProUGUI.alpha >= maxValueToOscillate)
                {
                    _increasing = false;
                }
            }
        }
    }
}
