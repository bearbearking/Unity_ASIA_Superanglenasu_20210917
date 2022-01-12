using UnityEngine;

/// <summary>
/// �ĤH�欰
/// �˴��ؼЪ���O�_�b�l�ܰϰ�
/// �l�ܻP�����ؼ�
/// </summary>
public class Enemy : MonoBehaviour
{
    #region ���
    [Header("�ˬd�l�ܰϰ�j�p�P�첾")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    [Header("�ʵe�Ѽ�")]
    public string parameterWalk = "�}������";
    public string paremeterAttack = "Ĳ�o����";
    [Header("���V�ؼЪ���")]
    public Transform target;
    [Header("�����Z��"), Range(0, 5)]
    public float attackDistance = 1.5f;
    [Header("�����N�o�ɶ�"), Range(0, 10)]
    public float attackCD = 1;
    [Header("�����ϰ�j�p�P�첾")]
    public Vector3 v3AttackSize = Vector3.one;
    public Vector3 v3AttackOffset;

    private float angle = 0;
    private Rigidbody2D rig;
    private Animator ani;
    private float timerAttack;
    #endregion

    #region �ƥ�
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    private void OnDrawGizmos()
    {
        //���w�ϥܪ��C��
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        //ø�s�ߤ���(���ߡA�ؤo)
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize);

        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize);
    }

    private void Update()
    {
        CheckTargetInArea();
    }
    #endregion

    #region ��k
    /// <summary>
    /// �ˬd�ؼЬO�_�b�ϰ줺
    /// </summary>
    private void CheckTargetInArea()
    {
        //2D���z.�л\����(���ߡA�ؤo�A����)
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize, 0, layerTarget);

        if (hit) Move();

    }

    ///<summary>
    ///����
    ///</summary>
    private void Move()
    {
        //�p�G �ؼЪ�X �p�� �ĤH��X �N�N���b���� ����0
        //�p�G �ؼЪ�X �j�� �ĤH��X �N�N���b�k�� ����180

        if (target.position.x > transform.position.x)
        {
            // �k�� angle = 180
        }
        else if (target.position.x < transform.position.x)
        {
            //  ���� angle = 0
        }
        //�T���B��l�y�k:���L�� ? �����L�� �� true : �����L�� �� false;
        angle = target.position.x > transform.position.x ? 180 : 0;

        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));
        ani.SetBool(parameterWalk, true);

        //�Z�� = �T���V�q.�Z��(A�I,B�I)
        float distance = Vector3.Distance(target.position, transform.position);
        //print("�P�ؼЪ��Z��: "+ distance);

        if(distance <= attackDistance)        //�p�G�Z�� �p�󵥩� �����Z��
        {
            rig.velocity = Vector3.zero;      //����
            Attack();
        }
    }

    [Header("�����O"), Range(0, 100)]
    public float attack = 20;
    private void Attack()
    {
        if(timerAttack < attackCD)            //�p�G�p�ɾ� �p�� �N�o�ɶ�
        {
            timerAttack += Time.deltaTime;    //�ɶ��֥[ Time.deltaTime�@�V�ɶ�
        }
        else
        {
            ani.SetTrigger(paremeterAttack);  //�p�G�p�ɾ� �j�󵥩� �N�o�ɶ� �N���� 
            timerAttack = 0;                //�p�ɾ��k�s
            Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize, 0, layerTarget);
            //print("�����쪫��:" + hit.name);
            hit.GetComponent<HurtSystem>().Hurt(attack);
        }
    }
    #endregion
}
