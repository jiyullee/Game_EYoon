﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI_Button_Retry : MonoBehaviour
{

    public void Onclick()
    {
        Loading.LoadScene("InGame 1");
    }
}
