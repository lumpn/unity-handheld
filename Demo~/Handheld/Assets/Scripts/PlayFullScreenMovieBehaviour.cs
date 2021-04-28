//----------------------------------------
// MIT License
// Copyright(c) 2021 Jonas Boetel
//----------------------------------------
using UnityEngine;

public sealed class PlayFullScreenMovieBehaviour : MonoBehaviour
{
    void Start()
    {
        Handheld.PlayFullScreenMovie(string.Empty, Color.white, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.Fill);
    }
}
