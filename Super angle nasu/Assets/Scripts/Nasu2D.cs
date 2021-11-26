using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nasu2D : MonoBehaviour
{
    #region 欄位:公開
    [Header("移動速度"), Range(0, 100)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 1500)]
    public float jump = 500;
    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    #endregion

    // Start is called before the first frame update
    private Rigidbody2D rig;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        Gizmos.DrawSphere(transform.position + 
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Flip();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }
    #region 方法
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        print("玩家左右按鍵值:" + h);

        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }

    private void Flip()
    {
        float h = Input.GetAxis("Horizontal");
        
        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if(h > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }
    #endregion
}
