using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCtr1 : MonoBehaviour
{
    private Animator _animator;
    public Slider slider;
    public int count;
    public float timer = 1f;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 25;
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
          slider.value -= Bird.health;
          Bird.health = 0;
        */
        if (Input.GetMouseButton(0)) _animator.SetBool("Ready", true);
        else _animator.SetBool("Ready", false);

        if (Bird.health >= 5)
        {
            _animator.SetBool("LastAttack", true);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                _animator.SetBool("LastAttack", false);
                slider.value -= Bird.health;
                Bird.health = 0;
                timer = 1f;
            }
        }
        else if (Bird.health <= 4 && Bird.health >= 3)
        {
            _animator.SetBool("Attack1", true);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                _animator.SetBool("Attack1", false);
                slider.value -= Bird.health;
                Bird.health = 0;
                timer = 1f;
            }
        }
        if(slider.value <= 0)
        {
            SceneManager.LoadScene("EndScene");
            slider.value = 25;
        }

    }
}
