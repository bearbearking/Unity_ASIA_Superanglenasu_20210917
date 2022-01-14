using UnityEngine;
using UnityEngine.UI;     //引用介面API
using UnityEngine.Events; //引用事件API

/// <summary>
/// 受傷系統
/// </summary>
public class HurtSystem : MonoBehaviour
{
    [Header("血條")]
    public Image imgHpBar;
    [Header("血量")]
    public float hp = 100;
    [Header("動畫參數")]
    public string paremeterDead = "觸發死亡";
    [Header("死亡事件")]
    public UnityEvent onDead;
    [Header("吃寶物回血"), Range(0, 20)]
    public int currenthp;


    private float hpMax;
    private Animator ani;



    //喚醒事件:在 Start 前執行一次
    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接受到的傷害</param>
    public void Hurt(float damage)
    {
        hp -= damage;
        imgHpBar.fillAmount = hp / hpMax;
        if (hp <= 0) Dead();
        ani.SetTrigger("觸發死亡");
    }

    private void Dead()
    {
        ani.SetTrigger(paremeterDead);
        onDead.Invoke();
    }

    public void GoodAngle(int amout)
    {
        currenthp = currenthp + 20;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
