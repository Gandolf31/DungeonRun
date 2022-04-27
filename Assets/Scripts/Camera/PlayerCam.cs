using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public GameObject Player;
    public int howFar;

    void Start()
    {
        Player = GameObject.Find("Player");    //추적대상 객체
    }
    void Update()
    {
        Vector3 TargetPos = new Vector3(Player.transform.position.x, Player.transform.position.y, howFar);
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * 2f);
    }
}
