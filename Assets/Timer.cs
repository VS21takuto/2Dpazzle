using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float countdown = 30f;//会議時間の設定
    public Text timetext;
    // Start is called before the first frame update
    void Start()
    {
        if (countdown <= 0) countdown = 300f;//初期設定をいじらない場合の会議時間
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        timetext.text = countdown.ToString("f1") + "秒";
        if (countdown <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
