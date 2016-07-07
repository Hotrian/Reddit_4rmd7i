using System;
using UnityEngine;

public class EventController : MonoBehaviour
{
    public static EventController Instance
    {
        get { return _instance ?? (_instance = FindObjectOfType<EventController>()); } // Return the instance or find it in the scene
    }

    private static EventController _instance;

    public Action<string> OnClick;

    public void DoClick(string var)
    {
        //Debug.Log("Do Click " + var);
        if (OnClick != null)
        {
            OnClick(var);
        }
    }
}
