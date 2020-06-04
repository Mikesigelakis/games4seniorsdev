using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeValueOnClickM : MonoBehaviour
{
    GameObject go_ca;
    GameObject go_cb;
    GameObject go_cc;
    GameObject go_cd;
    GameObject go_ce;
    GameObject go_cf;
    GameObject go_cg;
    GameObject go_ch;
    GameObject go_ci;

    public bool ma;
    public bool mb;
    public bool mc;
    public bool md;
    public bool me;
    public bool mf;
    public bool mg;
    public bool mh;
    public bool mi;

    // Start is called before the first frame update
    void Start()
    {
        go_ca = GameObject.Find("AC1");
        go_cb = GameObject.Find("AC2");
        go_cc = GameObject.Find("AC3");
        go_cd = GameObject.Find("AC4");
        go_ce = GameObject.Find("AC5");
        go_cf = GameObject.Find("AC6");
        go_cg = GameObject.Find("AC7");
        go_ch = GameObject.Find("AC8");
        go_ci = GameObject.Find("AC9");

    }

    private void Update()
{
        ma = go_ca.GetComponent<ColorSwap>().color;
        mb = go_cb.GetComponent<ColorSwap>().color;
        mc = go_cc.GetComponent<ColorSwap>().color;
        md = go_cd.GetComponent<ColorSwap>().color;
        me = go_ce.GetComponent<ColorSwap>().color;
        mf = go_cf.GetComponent<ColorSwap>().color;
        mg = go_cg.GetComponent<ColorSwap>().color;
        mh = go_ch.GetComponent<ColorSwap>().color;
        mi = go_ci.GetComponent<ColorSwap>().color;
    }

}
