using UnityEngine;

//������
//���L�� 2021/11/10
public class Nasu : MonoBehaviour
{
    #region ���P�y�k�Υ|�j�`������
    [Header("cc ��"), Range(500, 5000)]
    public int cc = 1000;
    [Header("���q"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("�D���W��"), Tooltip("�o�O�D���W��")]
    public string brand = "�X�X";
    [Header("�O�_���ѵ�")]
    public bool hasSkywindow = true;
    #endregion

    #region Unity ���������
    // �C�� Color
    public Color color;
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    // �V�q 2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v20ne = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Left = Vector2.left;
    public Vector2 v2Custom = new Vector2(1, 2);
    public Vector2 v3Custom = new Vector3(1, 2, 3);
    public Vector2 v4Custom = new Vector4(1, 2, 3, 4);
    // ���� Keycode
    public KeyCode keycode;
    public KeyCode keycodeJump = KeyCode.Space;
    // �C������ GameObject
    public GameObject goCamera;
    public GameObject goNasu;
    // ���� Component
    public Transform transCamera;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion

    #region �ƥ� : �{�����J�f
    // �}�l�ƥ�
    private void Start()
    {
        //�I�s��k : ��k�W��();
        Test();
        Walk(60);
        float w99 = ConvertWeight(9.9f);
        print("9.9 �ഫ :" + w99);

        print("���q�ഫ :" + ConvertWeight(weight));
    }
    #endregion
    #region ��k�y�k
    private void Test()
    {
        print("���o�A�U�w :D");
    }
    private void Walk(int speed)
    {
        print("�����t�� :" + speed);
        print("���� : �K�K�K");
    }

    private float ConvertWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}