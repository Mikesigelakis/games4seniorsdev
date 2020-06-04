using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckForVictory : MonoBehaviour
{
    // _m is for Map game object
    GameObject go_gr_m;
    

    // _p is for player game object
    GameObject go_gr_p;

    Scene m_Scene;
    string sceneName;
    public Text txtTimer;
    public Text txtRecord;
    public float myTimer;
    private int RecordTime;
    private int tempTimer;
    private bool timerOn = true;


    // Start is called before the first frame update
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        RecordTime = PlayerPrefs.GetInt(sceneName, 0);
        txtRecord.text = ("Record: " + RecordTime + "s");
        myTimer = 0;
        go_gr_m = GameObject.Find("AGrid");
        go_gr_p = GameObject.Find("BGrid");

        LoadSolution(sceneName);
    }

    // Update is called once per frame
    void Update()
    {

       //HERE DEBUG

        if (timerOn)
        {
            myTimer += Time.deltaTime;
            myTimer = myTimer * 100;
            tempTimer = (int)myTimer;
            myTimer = (float)tempTimer;
            myTimer = myTimer / 100;
            txtTimer.text = (myTimer + " secondes");
        }

        if (go_gr_p.GetComponent<ChangeValueOnClick>().pa ==
                go_gr_m.GetComponent<ChangeValueOnClickM>().mc)
            if (go_gr_p.GetComponent<ChangeValueOnClick>().pb ==
                    go_gr_m.GetComponent<ChangeValueOnClickM>().mb)
                if (go_gr_p.GetComponent<ChangeValueOnClick>().pc ==
                        go_gr_m.GetComponent<ChangeValueOnClickM>().ma)
                    if (go_gr_p.GetComponent<ChangeValueOnClick>().pd ==
                            go_gr_m.GetComponent<ChangeValueOnClickM>().mf)
                        if (go_gr_p.GetComponent<ChangeValueOnClick>().pe ==
                                go_gr_m.GetComponent<ChangeValueOnClickM>().me)
                            if (go_gr_p.GetComponent<ChangeValueOnClick>().pf ==
                                    go_gr_m.GetComponent<ChangeValueOnClickM>().md)
                                if (go_gr_p.GetComponent<ChangeValueOnClick>().pg ==
                                        go_gr_m.GetComponent<ChangeValueOnClickM>().mi)
                                    if (go_gr_p.GetComponent<ChangeValueOnClick>().ph ==
                                            go_gr_m.GetComponent<ChangeValueOnClickM>().mh)
                                        if (go_gr_p.GetComponent<ChangeValueOnClick>().pi ==
                                                go_gr_m.GetComponent<ChangeValueOnClickM>().mg)
                                        {
                                            TimerStop();
                                            PlayerPrefs.SetString("Last", sceneName);
                                            SceneManager.LoadScene("Victory");
                                        }

    }

    public void TimerStop()
    {
        timerOn = false;
        if ((RecordTime == 0) || (myTimer < RecordTime))
        {
            PlayerPrefs.SetInt(sceneName, (int)myTimer);
            RecordTime = (int)myTimer;
            txtRecord.text = ("Record: " + RecordTime + "s");
        }
    }

    private void LoadSolution(string sceneName)
    {
        //A Difficulty
        if (sceneName == "LevelAA")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;  
        }
        if (sceneName == "LevelAB")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
        }
        if (sceneName == "LevelAC")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
        }
        if (sceneName == "LevelAD")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
        }
        if (sceneName == "LevelAE")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
        }
        if (sceneName == "LevelAF")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelAG")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true; 
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelAH")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelAI")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelAJ")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelAK")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;  
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelAL")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelAM")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
        }
        if (sceneName == "LevelAN")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelAO")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        //B Difficulty
        if (sceneName == "LevelBA")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
        }
        if (sceneName == "LevelBB")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelBC")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
        }
        if (sceneName == "LevelBD")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
        }
        if (sceneName == "LevelBE")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelBF")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelBG")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
        }
        if (sceneName == "LevelBH")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
        }
        if (sceneName == "LevelBI")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelBJ")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
        }
        if (sceneName == "LevelBK")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
        }
        if (sceneName == "LevelBL")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
        }
        if (sceneName == "LevelBM")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelBN")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
        }
        if (sceneName == "LevelBO")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        //C Difficulty
        if (sceneName == "LevelCA")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelCB")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelCC")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelCD")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelCE")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelCF")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelCG")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
        }
        if (sceneName == "LevelCH")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelCI")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
        }
        if (sceneName == "LevelCJ")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mf = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
        }
        if (sceneName == "LevelCK")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelCL")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
        }
        if (sceneName == "LevelCM")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().md= true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me= true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi= true;
        }
        if (sceneName == "LevelCN")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
        if (sceneName == "LevelCO")
        {
            go_gr_m.GetComponent<ChangeValueOnClickM>().ma = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mb = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mc = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().me = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mg = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mh = true;
            go_gr_m.GetComponent<ChangeValueOnClickM>().mi = true;
        }
    }
}

