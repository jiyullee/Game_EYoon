﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : Singleton<Manager>
{
    static public int coin;
    public Text coinText;
    GameObject player;
    bool GameOver = true;
    public GameObject gameOverUI;
    public GameObject scoreUI;
    float delay = 3;
    private void Start()
    {
        coin = 0;
        player = GetComponent<LevelManager>().player;
    } 
           
    public void Gameover()
    {
        GameOver = false;
        player.GetComponent<PlayerMove>().forwardSpeed = 0;
        gameOverUI.SetActive(true);
        StartCoroutine(Delay(delay));
    }

    IEnumerator Delay(float delay)
    {        
        yield return new WaitForSeconds(delay);
        scoreUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void IncreaseCoin(int n)
    {
        coin += n;
        coinText.text = coin.ToString();
    }
}
