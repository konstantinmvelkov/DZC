﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    [SerializeField] GameObject endLevelMenu;

    void OnCollisionEnter2D(Collision2D col)
    {
        endLevelMenu.SetActive(true);
    }
}