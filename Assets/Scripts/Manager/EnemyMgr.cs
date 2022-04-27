using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class EnemyMgr : MonoBehaviour
{
    [SerializeField] float m_speed = 1.0f;
    GameObject Player;
    Transform m_playerPos;
    ScoreMgr SCMgr;

    private GameObject AtCollider;
    private GameObject ScoreMgr;
    public float isAttack;
    public bool LAttack = false;
    public bool RAttack = false;

    private Animator m_animator;
    private Rigidbody2D m_body2d;
    private bool m_isDead = false;
    public int nextMove;
    private int E_hp = 20;

    // Use this for initialization
    void Awake()
    {
        ScoreMgr = GameObject.Find("ScoreManager");
        SCMgr = ScoreMgr.GetComponent<ScoreMgr>();
        Player = GameObject.Find("Player");
        m_playerPos = Player.transform;
        AtCollider = transform.Find("AtCollider").gameObject;
        m_animator = GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();
        Invoke("Think", 0.5f);
    }

    void Think()
    {
        nextMove = Random.Range(-1, 2);

        Invoke("Think", 0.5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isAttack = m_playerPos.position.x - transform.position.x;
        if(isAttack > 0)
        {
            RAttack = true;
        }
        else
        {
            LAttack = true;
        }
        m_body2d.velocity = new Vector2(nextMove, m_body2d.velocity.y);

        if (nextMove > 0)
        {
            transform.localScale = new Vector2(-3.0f, 3.0f);
        }
        else if (nextMove < 0)
        {
            transform.localScale = new Vector2(3.0f, 3.0f);
        }

        m_body2d.velocity = new Vector2(nextMove * m_speed, m_body2d.velocity.y);
        //Walk
        if (Mathf.Abs(nextMove) > Mathf.Epsilon && !m_isDead)
            m_animator.SetInteger("AnimState", 1);
        else if (Mathf.Abs(isAttack) <= 2 && !m_isDead)
            if (RAttack)
            {
                nextMove = 1;
                m_animator.SetTrigger("Attack");
                RAttack = false;
            }
            else if(LAttack)
            {
                nextMove = -1;
                m_animator.SetTrigger("Attack");
                RAttack = false;
            }
            //Idle
        else
            m_animator.SetInteger("AnimState", 0);
    }
    void isDead()
    {
        this.gameObject.tag = "Player";
        m_animator.SetTrigger("Death");
        m_isDead = true;
        Invoke("DeActive", 1);
        SCMgr.nowScore += 10;
    }
    void DeActive ()
    {
        gameObject.SetActive(false);
    }
    public void Attacked()
    {
        if (!m_isDead)
        {
            E_hp -= 10;
            m_animator.SetTrigger("Hurt");
            if (E_hp <= 0)
                isDead();
        }
    }
    public void AttackOnOff ()
    {
        AtCollider.SetActive(!AtCollider.activeInHierarchy);
    }
}