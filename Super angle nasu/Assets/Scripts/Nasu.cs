using UnityEngine;

//單行註解
//壹貳參 2021/11/10
public class Nasu : MonoBehaviour
{
    #region 欄位與語法及四大常用類型
    [Header("cc 數"), Range(500, 5000)]
    public int cc = 1000;
    [Header("重量"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("主角名稱"), Tooltip("這是主角名稱")]
    public string brand = "茄茄";
    [Header("是否有天窗")]
    public bool hasSkywindow = true;
    #endregion

    #region Unity 內資料類型
    // 顏色 Color
    public Color color;
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    // 向量 2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v20ne = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Left = Vector2.left;
    public Vector2 v2Custom = new Vector2(1, 2);
    public Vector2 v3Custom = new Vector3(1, 2, 3);
    public Vector2 v4Custom = new Vector4(1, 2, 3, 4);
    // 按鍵 Keycode
    public KeyCode keycode;
    public KeyCode keycodeJump = KeyCode.Space;
    // 遊戲物件 GameObject
    public GameObject goCamera;
    public GameObject goNasu;
    // 元件 Component
    public Transform transCamera;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion

    #region 事件 : 程式的入口
    // 開始事件
    private void Start()
    {
        //呼叫方法 : 方法名稱();
        Test();
        Walk(60);
        float w99 = ConvertWeight(9.9f);
        print("9.9 轉換 :" + w99);

        print("重量轉換 :" + ConvertWeight(weight));
    }
    #endregion
    #region 方法語法
    private void Test()
    {
        print("哈囉，沃德 :D");
    }
    private void Walk(int speed)
    {
        print("走路速度 :" + speed);
        print("音效 : 嘿嘿嘿");
    }

    private float ConvertWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}