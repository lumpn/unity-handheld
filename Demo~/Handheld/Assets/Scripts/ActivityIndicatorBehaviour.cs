//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEngine;

public sealed class ActivityIndicatorBehaviour : MonoBehaviour
{
    void Start()
    {
        Handheld.SetActivityIndicatorStyle(AndroidActivityIndicatorStyle.Small);
    }

    void OnDestroy()
    {
        Handheld.GetActivityIndicatorStyle();
    }

    void OnEnable()
    {
        Handheld.StartActivityIndicator();
    }

    void OnDisable()
    {
        Handheld.StopActivityIndicator();
    }
}
