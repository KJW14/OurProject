using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Human
{
    // Rigidbody
    private Rigidbody playerRigidbody;
    // HP
    // 공격력
    // 이동속도

    // 스테미너
    private float playerStamina;
    // 점프중
    private bool isJump;
    // 점프파워
    private float jumpPower;
    // 대기()
    // 걷기()
    // 공격()
    // 죽음()

    // 점프()
    // 뛰기()
    // 앉기()
    // 앉아 걷기()
    // 대쉬()
    // 무기교체()

    // 점프()
    // 뛰기()
    // 앉기()
    // 앉아 걷기()
    // 대쉬()
    // 무기교체()

    void RigidbodyMove()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(inputX, 0, inputZ) * moveSpeed;

        playerRigidbody.velocity = velocity;
        if (inputX != 0 || inputZ != 0)
        {
            Debug.LogWarning("RigidbodyMove");
        }

        //Vector3 vector3 = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime;
        //playerRigidbody.velocity = vector3;
    }
    void RigidbodyJump()
    {
        if (isJump)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;

            //playerRigidbody.velocity = Vector3.zero;
            playerRigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);

            // animator.SetBool("IsJumping", true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0f)
        {
            isJump = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 50f;
        jumpPower = 100f;
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        RigidbodyMove();
        RigidbodyJump();
    }
}
