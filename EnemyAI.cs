using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 3f;
    public float attackRange = 2f;
    public float attackDamage = 10f;

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= attackRange)
        {
            // 攻撃処理
            AttackPlayer();
        }
        else
        {
            // プレイヤーに向かって移動
            MoveTowardsPlayer();
        }
    }

    private void MoveTowardsPlayer()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * moveSpeed * Time.deltaTime;
    }

    private void AttackPlayer()
    {
        // プレイヤーにダメージを与える処理
        Debug.Log("Player attacked!");
    }
}
