using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCtrl : MonoBehaviour
{
    public GameObject m_forest;
    public GameObject m_cave;
    // Start is called before the first frame update
    void Start()
    {
        int CheckBack = Random.Range(0, 2);
        if (CheckBack == 0)
        {
            m_forest.SetActive(true);
            m_cave.SetActive(false);
        }
        else if (CheckBack == 1)
        {
            m_forest.SetActive(false);
            m_cave.SetActive(true);
        }
    }
}
