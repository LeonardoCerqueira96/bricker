﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        FindObjectOfType<SceneLoader>().LoadSceneByName("Game Over");
    }
}
