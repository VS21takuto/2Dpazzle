using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Hp : MonoBehaviour
{
    public Slider sd;
    // Start is called before the first frame update
    void Start()
    {
        sd.value = 50;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
