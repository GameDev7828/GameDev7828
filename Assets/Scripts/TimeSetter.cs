using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSetter : MonoBehaviour
{
    private void Start()
    {
        SetTimeScale(1);
    }

    public void SetTimeScale(int timeScale)
    {
        Time.timeScale = timeScale;
    }
}
