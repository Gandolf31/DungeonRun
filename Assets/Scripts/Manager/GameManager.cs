using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public int coin = 0;
    public int score = 0;
    public int preCoin = 0;
    private bool isGet = false;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.gm == null)
        {
            GameManager.gm = this;
        }
        var a = FindObjectsOfType<GameManager>();
        if (a.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void GetCoin()
    {
        coin += preCoin;
    }
}
