﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI_GameOver : MonoBehaviour
{
    
    public Image backGround;
    public float alphaSpeed;
    public GameObject texts;
    Color alpha;
    float time = 0;
    void Start()
    {
        alpha = backGround.color;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        alpha.a = Mathf.Lerp(alpha.a, 255, Time.deltaTime * alphaSpeed);
        backGround.color = alpha;
        if (time >= 1.5f)
        {
            texts.SetActive(true);
            int touchCount = Input.touchCount;
            if(touchCount > 0 || Input.GetKeyDown(KeyCode.A))
            {
                SceneManager.LoadScene("Main");
            }
        }
    }
}
