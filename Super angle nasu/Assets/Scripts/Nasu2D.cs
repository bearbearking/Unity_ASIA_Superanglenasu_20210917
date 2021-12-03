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
    [Header("動畫參數:走路與跳躍")]
    public string parameterWalk = "走路開關";
    public string parameterJump = "跳躍開關";
    #endregion

    #region  欄位:私人
    // Start is called before the first frame update
    private Animator ani;
    private Rigidbody2D rig;

    [SerializeField]

    private bool isGrounded;

    #endregion

    #region 事件
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        Gizmos.DrawSphere(transform.position + 
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    private void Update()
    {
        Flip();
        CheckGround();
        Jump();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }
    #endregion

    #region 方法
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        //print("玩家左右按鍵值:" + h);

        rig.velocity = new Vector2(h * speed, rig.velocity.y);
        ani.SetBool(parameterWalk, h != 0);
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

    private void CheckGround()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position +
            transform.TransformDirection(checkGroundOffset), checkGroundRadius, canJumpLayer);

        //print("碰到的物件名稱:" + hit.name);
        
        isGrounded = hit;

        ani.SetBool(parameterJump, !isGrounded);
    }
    private void Jump()
    {
        if (isGrounded && Input.GetKeyDown(keyJump))
        {
            rig.AddForce(new Vector2(0, jump));
        }
    }
    #endregion
}
