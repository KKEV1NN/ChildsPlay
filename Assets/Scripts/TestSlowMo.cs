using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


//this is for testing slowmo

public class TestSlowMo : MonoBehaviour
{
    public Slider slowMoBar;
    public bool slowMoStart;
    public bool slowMoCool;


    // Start is called before the first frame update
    void Start()
    {
        slowMoBar = GameObject.FindObjectOfType<Slider>();
        //slowMoStart = true;


    }

    // Update is called once per frame
    void Update()
    {
        if (!slowMoCool && Input.GetKey(KeyCode.V))
        {
            SlowMo(false);
            slowMoStart = true;

            slowMoBar.value -= Time.unscaledDeltaTime;
        }
        else
        {
            SlowMo(true);
            slowMoStart = false;

        if(slowMoBar.value <= 0)
        {
            SlowMo(false);
        }

        SlowMoCDW();
    }

    void SlowMo(bool b)
    {

        if (b)
        {
            Time.timeScale = 1;
            Time.fixedDeltaTime = 0.02f;

        }
        else
        {
            Time.timeScale = 0.25f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
    }

            slowMoBar.value += Time.unscaledDeltaTime;
        }
    }

    void ChangeBool()
    {
        slowMoCool = false;
    }
}
