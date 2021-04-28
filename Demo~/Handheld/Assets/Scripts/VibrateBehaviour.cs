//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEngine;

public sealed class VibrateBehaviour : MonoBehaviour
{
    void Start()
    {
        Handheld.Vibrate();
    }
}
