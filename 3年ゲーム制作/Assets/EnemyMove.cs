using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public int speed;
    void FixedUpdate()
    {
        // プレイヤー-敵キャラの位置関係から方向を取得し、速度を一定化
        Vector2 targeting = (player.transform.position - this.transform.position).normalized;
        if (targeting.x > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        // x方向にのみプレイヤーを追う
        this.GetComponent<Rigidbody2D>().velocity = new Vector2((targeting.x * speed), 0);
    }
}
