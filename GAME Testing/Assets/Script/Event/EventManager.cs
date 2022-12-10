using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static event Action OpenDoorEvent;
    public static event Action OpenInspectEvent;

    public static void StartDoorEvent()
    {

        OpenDoorEvent?.Invoke();

    }
    public static void StartInspectEvent()
    {
        OpenInspectEvent?.Invoke();
    }

}
