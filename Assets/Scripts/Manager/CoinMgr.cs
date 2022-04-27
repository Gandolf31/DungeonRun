using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinMgr : MonoBehaviour
{
    GameObject GameManager;
    GameManager gm;
    public Text coinText;
    public Text scoreText;
    public int coin = 0;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    { 
        GameManager = GameObject.Find("GameManager");
        gm = GameManager.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        coin = gm.preCoin;
        coinText.text = ("Coin : " + coin);
        score = gm.score;
        scoreText.text = ("Score : " + score);
    }
}
