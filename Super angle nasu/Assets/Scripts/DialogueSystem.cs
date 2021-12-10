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

    private void Start()
    {
        StartCoroutine(TypeEffect());
    }

    private IEnumerator TypeEffect()
    {
        string test = "I WANNA BE AN ANGEL!!";

        textContent.text = "";
        goDialogue.SetActive(true);

        for (int i = 0; i < test.Length; i++)
        {
            textContent.text += test[i];
            yield return new WaitForSeconds(interval);
        }
    }
}
