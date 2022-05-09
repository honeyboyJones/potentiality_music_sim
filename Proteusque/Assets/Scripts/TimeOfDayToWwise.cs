using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDayToWwise : MonoBehaviour
{
    public AK.Wwise.RTPC timeOfDay;

    //public LightingManager lightingManager;

    //called once per frame
    void Update()
    {
        timeOfDay.SetGlobalValue(DayNightController.timeWwise);

        //timeOfDay.Equals(LightingManager.TimeOfDay);

        //print("TIME OF DAY IS: " + LightingManager.TimeOfDay);
        //print("TOD IS: " + timeOfDay);  
    }
}
