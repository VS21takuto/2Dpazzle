using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Text tt;
    // Start is called before the first frame update
    void Start()
    {
        tt.text = "結果 : " + Bird.count.ToString() + "pt！！";
        Bird.count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
