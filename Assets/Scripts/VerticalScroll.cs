﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScroll : MonoBehaviour
{
    [Tooltip("Game units per second")]
    [SerializeField] float scrollRate = 0.2f;

    // Update is called once per frame
    void Update()
    {
        float yMove = Time.deltaTime * scrollRate;
        transform.Translate(new Vector3(0f, yMove, 0f));
    }
}
