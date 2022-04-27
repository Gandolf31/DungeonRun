using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMgr : MonoBehaviour
{
    GameObject GameManager;
    GameManager gm;
    public int nowScore;
    public int firstRewards = 100;
    public int Coin;
    public int CaveScore = 100;
    public GameObject Forest;
    public GameObject Cave;

    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        gm = GameManager.GetComponent<GameManager>();
        nowScore = 0;
        Forest.SetActive(true);
        Cave.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(nowScore >= CaveScore)
        {
            Forest.SetActive(false);
            Cave.SetActive(true);
        }
        ScoreText.text = ("Score : " + nowScore);
    }
    public void ExChange()
    {
        Coin = nowScore / 10;
        gm.preCoin = Coin;
        gm.GetCoin();
        gm.score = nowScore;
    }
}
