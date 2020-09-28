using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Human : MonoBehaviour
{
    // HP
    // 공격력
    // 이동속도
    // 걷기()
    // 뛰기()
    // 공격()
    // 죽음()

    // 보류
    // 대기()
    public GameObject obj;
    public Animator animator;
    // HP
    protected int hp;
    // 공격력
    protected int ap;
    // 이동속도
    protected float moveSpeed;

    // 공격()
    protected void Attack()
    {

    }
    // 죽음()
    public void Die()
    {

    }
    // 대기()
    void Idle()
    {

    }
}
