using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Human
{
    // HP
    // 공격력
    // 이동속도

    // 대기()
    // 걷기()
    // 공격()
    // 죽음()

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        OnDrawGizmos();
    }
    void EnemyRaycast()
    {
    }
    private void OnDrawGizmos()
    {
        float maxDistance = 40;
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, maxDistance, transform.forward, 0);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, maxDistance);

        foreach (var hit in hits)
        {
            if (hit.collider != null)
            {
                Debug.Log("collider : " + hit.collider.name);
                Player player = hit.collider.GetComponent<Player>();

                if (player != null)
                {
                    Debug.Log("Player 찾음!");
                    Vector3 direction = (player.transform.position - transform.position).normalized;
                    Gizmos.DrawRay(transform.position, transform.forward * hit.distance);
                    transform.position += direction * moveSpeed * Time.deltaTime;
                }
            }
        }
    }
}
