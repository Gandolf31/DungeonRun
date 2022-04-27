using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinMgrT : MonoBehaviour
{
    GameObject GameManager;
    GameManager gm;
    public Text coinText;
    int preCoin;
    int coin;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        gm = GameManager.GetComponent<GameManager>();
        preCoin = gm.preCoin;
        coin = gm.coin;
    }
    void Update()
    {
        coinText.text = ("Coin : " + coin);
    }
}
