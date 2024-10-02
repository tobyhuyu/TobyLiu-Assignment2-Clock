using System;
using UnityEngine;

public class clock : MonoBehaviour {

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform HoursPivot, MinutesPivot, SecondsPivot;
    
    void Update () {

        TimeSpan time = DateTime.Now.TimeOfDay;

        HoursPivot.localRotation = Quaternion.Euler(0f, -hoursToDegrees * (float)time.TotalHours,0f);
        MinutesPivot.localRotation =Quaternion.Euler(0f,-minutesToDegrees * (float)time.TotalMinutes, 0f);
        SecondsPivot.localRotation =Quaternion.Euler(0f, -secondsToDegrees * (float)time.TotalSeconds, 0f);

    }
}
