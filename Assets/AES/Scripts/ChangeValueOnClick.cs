using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeValueOnClick : MonoBehaviour
{
    GameObject go_cap;
    GameObject go_cbp;
    GameObject go_ccp;
    GameObject go_cdp;
    GameObject go_cep;
    GameObject go_cfp;
    GameObject go_cgp;
    GameObject go_chp;
    GameObject go_cip;

    public bool pa = false;
    public bool pb = false;
    public bool pc = false;
    public bool pd = false;
    public bool pe = false;
    public bool pf = false;
    public bool pg = false;
    public bool ph = false;
    public bool pi = false;

    // Start is called before the first frame update
    void Start()
    {
        go_cap = GameObject.Find("BC1");
        go_cbp = GameObject.Find("BC2");
        go_ccp = GameObject.Find("BC3");
        go_cdp = GameObject.Find("BC4");
        go_cep= GameObject.Find("BC5");
        go_cfp = GameObject.Find("BC6");
        go_cgp = GameObject.Find("BC7");
        go_chp = GameObject.Find("BC8");
        go_cip = GameObject.Find("BC9");

    }

    private void Update()
{
        pa = go_cap.GetComponent<ColorSwap>().color;
        pb = go_cbp.GetComponent<ColorSwap>().color;
        pc = go_ccp.GetComponent<ColorSwap>().color;
        pd = go_cdp.GetComponent<ColorSwap>().color;
        pe = go_cep.GetComponent<ColorSwap>().color;
        pf = go_cfp.GetComponent<ColorSwap>().color;
        pg = go_cgp.GetComponent<ColorSwap>().color;
        ph = go_chp.GetComponent<ColorSwap>().color;
        pi = go_cip.GetComponent<ColorSwap>().color;

    }

}
