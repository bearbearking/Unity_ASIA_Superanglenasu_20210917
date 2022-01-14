using UnityEngine;
using UnityEngine.UI;     //�ޥΤ���API
using UnityEngine.Events; //�ޥΨƥ�API

/// <summary>
/// ���˨t��
/// </summary>
public class HurtSystem : MonoBehaviour
{
    [Header("���")]
    public Image imgHpBar;
    [Header("��q")]
    public float hp = 100;
    [Header("�ʵe�Ѽ�")]
    public string paremeterDead = "Ĳ�o���`";
    [Header("���`�ƥ�")]
    public UnityEvent onDead;
    [Header("�Y�_���^��"), Range(0, 20)]
    public int currenthp;


    private float hpMax;
    private Animator ani;



    //����ƥ�:�b Start �e����@��
    private void Awake()
    {
        ani = GetComponent<Animator>();
        hpMax = hp;
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damage">�����쪺�ˮ`</param>
    public void Hurt(float damage)
    {
        hp -= damage;
        imgHpBar.fillAmount = hp / hpMax;
        if (hp <= 0) Dead();
        ani.SetTrigger("Ĳ�o���`");
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
