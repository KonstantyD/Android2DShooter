﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delet : MonoBehaviour
{
    int i = 0;
    public GameObject ded;
    // Update is called once per frame
    void Update()
    {
        i++;
        if (i > 12)
        {
            Destroy(gameObject);
        }
    }
}
