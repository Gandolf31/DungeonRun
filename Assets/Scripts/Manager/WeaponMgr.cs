using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMgr : MonoBehaviour
{
    EnemyMgr EMgr;
    PrototypeHero PMgr;

    public GameObject Zombie;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        EMgr = Zombie.GetComponent<EnemyMgr>();
        PMgr = Player.GetComponent<PrototypeHero>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ts");
        if (collision.gameObject.layer == 9)
        {
            EMgr.Attacked();
        }
    }
}
