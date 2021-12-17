using UnityEngine;
using UnityEngine.UI;
using System.Collections;

///<summary>
///對話系統
///將需要輸出的文字利用打字效果呈現
///</summary>
public class DialogueSystem : MonoBehaviour
{
    [Header("對話間隔"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("畫布對話系統")]
    public GameObject goDialogue;
    [Header("說話內容")]
    public Text textContent;
    [Header("對話完成圖示")]
    public GameObject goTip;
    [Header("對話按鍵")]
    public KeyCode keyDialogue = KeyCode.Mouse0;

    private void Start()
    {
        string test1 = "I WANNA BE AN ANGEL!!";
        string test2 = "HA!HA!HA!";
        string[] test = { test1, test2};
        StartCoroutine(TypeEffect(test));
    }
    /// <summary>
    /// 打字效果
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>

    private IEnumerator TypeEffect(string[] content)
    {


        goDialogue.SetActive(true);                               //顯示對話物件

        for ( int j = 0; j < content.Length; j++)                 //遍尋所有對話
        {
            textContent.text = "";                               //清除上次對話內容
            goTip.SetActive(false);                              //隱藏提示圖示 三角形   
            for (int i = 0; i < content[j].Length; i++)           //遍尋對話的每個字
            {
                textContent.text += content[j][i];                //疊加對話內容文字介面
                yield return new WaitForSeconds(interval);
            }
            goTip.SetActive(true);                               //顯示對話完成圖示 三角形

            while (!Input.GetKeyDown(keyDialogue))                //當玩家沒有按對話按鍵持續等待
            {
                yield return null;                              //等待null 一個影格時間 
            }
        }
        goDialogue.SetActive(false);                             //隱藏對話事件
    }

    
    ///<summary>
    ///開始對話
    ///</summary>
    public void StartDialogue(string[] contents)
    {
        StartCoroutine(TypeEffect(contents));
    }

    ///<summary>
    ///停止對話
    ///</summary>
    public void StopDialogue()
    {
        StopAllCoroutines();
        goDialogue.SetActive(false);
    }
}
