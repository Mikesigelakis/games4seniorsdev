using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    Scene m_Scene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoToLaunch()
    {
        SceneManager.LoadScene("Launch");
    }
    public void GoToMenu()
    {
        string sceneName;
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        if (sceneName == "LevelAA")
            SceneManager.LoadScene("ADifficulty");
        else if (sceneName == "LevelAB")
            SceneManager.LoadScene("ADifficulty");
        else if (sceneName == "LevelAC")
            SceneManager.LoadScene("ADifficulty");
        else if (sceneName == "LevelAD")
            SceneManager.LoadScene("ADifficulty");
        else if (sceneName == "LevelAE")
            SceneManager.LoadScene("ADifficulty");
        else if (sceneName == "LevelAF")
            SceneManager.LoadScene("ADifficultyB");
        else if (sceneName == "LevelAG")
            SceneManager.LoadScene("ADifficultyB");
        else if (sceneName == "LevelAH")
            SceneManager.LoadScene("ADifficultyB");
        else if (sceneName == "LevelAI")
            SceneManager.LoadScene("ADifficultyB");
        else if (sceneName == "LevelAJ")
            SceneManager.LoadScene("ADifficultyB");
        else if (sceneName == "LevelAK")
            SceneManager.LoadScene("ADifficultyC");
        else if (sceneName == "LevelAL")
            SceneManager.LoadScene("ADifficultyC");
        else if (sceneName == "LevelAM")
            SceneManager.LoadScene("ADifficultyC");
        else if (sceneName == "LevelAN")
            SceneManager.LoadScene("ADifficultyC");
        else if (sceneName == "LevelAO")
            SceneManager.LoadScene("ADifficultyC");
        else if (sceneName == "LevelBA")
            SceneManager.LoadScene("BDifficulty");
        else if (sceneName == "LevelBB")
            SceneManager.LoadScene("BDifficulty");
        else if (sceneName == "LevelBC")
            SceneManager.LoadScene("BDifficulty");
        else if (sceneName == "LevelBD")
            SceneManager.LoadScene("BDifficulty");
        else if (sceneName == "LevelBE")
            SceneManager.LoadScene("BDifficulty");
        else if (sceneName == "LevelBF")
            SceneManager.LoadScene("BDifficultyB");
        else if (sceneName == "LevelBG")
            SceneManager.LoadScene("BDifficultyB");
        else if (sceneName == "LevelBH")
            SceneManager.LoadScene("BDifficultyB");
        else if (sceneName == "LevelBI")
            SceneManager.LoadScene("BDifficultyB");
        else if (sceneName == "LevelBJ")
            SceneManager.LoadScene("BDifficultyB");
        else if (sceneName == "LevelBK")
            SceneManager.LoadScene("BDifficultyC");
        else if (sceneName == "LevelBL")
            SceneManager.LoadScene("BDifficultyC");
        else if (sceneName == "LevelBM")
            SceneManager.LoadScene("BDifficultyC");
        else if (sceneName == "LevelBN")
            SceneManager.LoadScene("BDifficultyC");
        else if (sceneName == "LevelBO")
            SceneManager.LoadScene("BDifficultyC");
        else if (sceneName == "LevelCA")
            SceneManager.LoadScene("CDifficulty");
        else if (sceneName == "LevelCB")
            SceneManager.LoadScene("CDifficulty");
        else if (sceneName == "LevelCC")
            SceneManager.LoadScene("CDifficulty");
        else if (sceneName == "LevelCD")
            SceneManager.LoadScene("CDifficulty");
        else if (sceneName == "LevelCE")
            SceneManager.LoadScene("CDifficulty");
        else if (sceneName == "LevelCF")
            SceneManager.LoadScene("CDifficultyB");
        else if (sceneName == "LevelCG")
            SceneManager.LoadScene("CDifficultyB");
        else if (sceneName == "LevelCH")
            SceneManager.LoadScene("CDifficultyB");
        else if (sceneName == "LevelCI")
            SceneManager.LoadScene("CDifficultyB");
        else if (sceneName == "LevelCJ")
            SceneManager.LoadScene("CDifficultyB");
        else if (sceneName == "LevelCK")
            SceneManager.LoadScene("CDifficultyC");
        else if (sceneName == "LevelCL")
            SceneManager.LoadScene("CDifficultyC");
        else if (sceneName == "LevelCM")
            SceneManager.LoadScene("CDifficultyC");
        else if (sceneName == "LevelCN")
            SceneManager.LoadScene("CDifficultyC");
        else if (sceneName == "LevelCO")
            SceneManager.LoadScene("CDifficultyC");
        else
            SceneManager.LoadScene("Menu");
    }

    public void goToMainMenu(){
         SceneManager.LoadScene("MainScene");
    }
    public void GoToADifficulty()
    {
        SceneManager.LoadScene("ADifficulty");
    }
    public void GoToADifficultyB()
    {
        SceneManager.LoadScene("ADifficultyB");
    }
    public void GoToADifficultyC()
    {
        SceneManager.LoadScene("ADifficultyC");
    }
    public void GoToBDifficulty()
    {
        SceneManager.LoadScene("BDifficulty");
    }
    public void GoToBDifficultyB()
    {
        SceneManager.LoadScene("BDifficultyB");
    }
    public void GoToBDifficultyC()
    {
        SceneManager.LoadScene("BDifficultyC");
    }
    public void GoToCDifficulty() => SceneManager.LoadScene("CDifficulty");
    public void GoToCDifficultyB() => SceneManager.LoadScene("CDifficultyB");
    public void GoToCDifficultyC() => SceneManager.LoadScene("CDifficultyC");

    public void GoToLevelAA() => SceneManager.LoadScene("LevelAA");
    public void GoToLevelAB() => SceneManager.LoadScene("LevelAB");
    public void GoToLevelAC() => SceneManager.LoadScene("LevelAC");
    public void GoToLevelAD() => SceneManager.LoadScene("LevelAD");
    public void GoToLevelAE() => SceneManager.LoadScene("LevelAE");
    public void GoToLevelAF() => SceneManager.LoadScene("LevelAF");
    public void GoToLevelAG() => SceneManager.LoadScene("LevelAG");
    public void GoToLevelAH() => SceneManager.LoadScene("LevelAH");
    public void GoToLevelAI() => SceneManager.LoadScene("LevelAI");
    public void GoToLevelAJ() => SceneManager.LoadScene("LevelAJ");
    public void GoToLevelAK() => SceneManager.LoadScene("LevelAK");
    public void GoToLevelAL() => SceneManager.LoadScene("LevelAL");
    public void GoToLevelAM() => SceneManager.LoadScene("LevelAM");
    public void GoToLevelAN() => SceneManager.LoadScene("LevelAN");
    public void GoToLevelAO() => SceneManager.LoadScene("LevelAO");
    public void GoToLevelBA() => SceneManager.LoadScene("LevelBA");
    public void GoToLevelBB() => SceneManager.LoadScene("LevelBB");
    public void GoToLevelBC() => SceneManager.LoadScene("LevelBC");
    public void GoToLevelBD() => SceneManager.LoadScene("LevelBD");
    public void GoToLevelBE() => SceneManager.LoadScene("LevelBE");
    public void GoToLevelBF() => SceneManager.LoadScene("LevelBF");
    public void GoToLevelBG() => SceneManager.LoadScene("LevelBG");
    public void GoToLevelBH() => SceneManager.LoadScene("LevelBH");
    public void GoToLevelBI() => SceneManager.LoadScene("LevelBI");
    public void GoToLevelBJ() => SceneManager.LoadScene("LevelBJ");
    public void GoToLevelBK() => SceneManager.LoadScene("LevelBK");
    public void GoToLevelBL() => SceneManager.LoadScene("LevelBL");
    public void GoToLevelBM() => SceneManager.LoadScene("LevelBM");
    public void GoToLevelBN() => SceneManager.LoadScene("LevelBN");
    public void GoToLevelBO() => SceneManager.LoadScene("LevelBO");
    public void GoToLevelCA() => SceneManager.LoadScene("LevelCA");
    public void GoToLevelCB() => SceneManager.LoadScene("LevelCB");
    public void GoToLevelCC() => SceneManager.LoadScene("LevelCC");
    public void GoToLevelCD() => SceneManager.LoadScene("LevelCD");
    public void GoToLevelCE() => SceneManager.LoadScene("LevelCE");
    public void GoToLevelCF() => SceneManager.LoadScene("LevelCF");
    public void GoToLevelCG() => SceneManager.LoadScene("LevelCG");
    public void GoToLevelCH() => SceneManager.LoadScene("LevelCH");
    public void GoToLevelCI() => SceneManager.LoadScene("LevelCI");
    public void GoToLevelCJ() => SceneManager.LoadScene("LevelCJ");
    public void GoToLevelCK() => SceneManager.LoadScene("LevelCK");
    public void GoToLevelCL() => SceneManager.LoadScene("LevelCL");
    public void GoToLevelCM() => SceneManager.LoadScene("LevelCM");
    public void GoToLevelCN() => SceneManager.LoadScene("LevelCN");
    public void GoToLevelCO() => SceneManager.LoadScene("LevelCO");

    public void GoToEndLvl()
    {
        string sceneName = PlayerPrefs.GetString("Last");
                                                if (sceneName == "LevelAA")
                                                SceneManager.LoadScene("ADifficulty");
                                            else if (sceneName == "LevelAB")
                                                SceneManager.LoadScene("ADifficulty");
                                            else if (sceneName == "LevelAC")
                                                SceneManager.LoadScene("ADifficulty");
                                            else if (sceneName == "LevelAD")
                                                SceneManager.LoadScene("ADifficulty");
                                            else if (sceneName == "LevelAE")
                                                SceneManager.LoadScene("ADifficulty");
                                            else if (sceneName == "LevelAF")
                                                SceneManager.LoadScene("ADifficultyB");
                                            else if (sceneName == "LevelAG")
                                                SceneManager.LoadScene("ADifficultyB");
                                            else if (sceneName == "LevelAH")
                                                SceneManager.LoadScene("ADifficultyB");
                                            else if (sceneName == "LevelAI")
                                                SceneManager.LoadScene("ADifficultyB");
                                            else if (sceneName == "LevelAJ")
                                                SceneManager.LoadScene("ADifficultyB");
                                            else if (sceneName == "LevelAK")
                                                SceneManager.LoadScene("ADifficultyC");
                                            else if (sceneName == "LevelAL")
                                                SceneManager.LoadScene("ADifficultyC");
                                            else if (sceneName == "LevelAM")
                                                SceneManager.LoadScene("ADifficultyC");
                                            else if (sceneName == "LevelAN")
                                                SceneManager.LoadScene("ADifficultyC");
                                            else if (sceneName == "LevelAO")
                                                SceneManager.LoadScene("ADifficultyC");
                                            else if (sceneName == "LevelBA")
                                                SceneManager.LoadScene("BDifficulty");
                                            else if (sceneName == "LevelBB")
                                                SceneManager.LoadScene("BDifficulty");
                                            else if (sceneName == "LevelBC")
                                                SceneManager.LoadScene("BDifficulty");
                                            else if (sceneName == "LevelBD")
                                                SceneManager.LoadScene("BDifficulty");
                                            else if (sceneName == "LevelBE")
                                                SceneManager.LoadScene("BDifficulty");
                                            else if (sceneName == "LevelBF")
                                                SceneManager.LoadScene("BDifficultyB");
                                            else if (sceneName == "LevelBG")
                                                SceneManager.LoadScene("BDifficultyB");
                                            else if (sceneName == "LevelBH")
                                                SceneManager.LoadScene("BDifficultyB");
                                            else if (sceneName == "LevelBI")
                                                SceneManager.LoadScene("BDifficultyB");
                                            else if (sceneName == "LevelBJ")
                                                SceneManager.LoadScene("BDifficultyB");
                                            else if (sceneName == "LevelBK")
                                                SceneManager.LoadScene("BDifficultyC");
                                            else if (sceneName == "LevelBL")
                                                SceneManager.LoadScene("BDifficultyC");
                                            else if (sceneName == "LevelBM")
                                                SceneManager.LoadScene("BDifficultyC");
                                            else if (sceneName == "LevelBN")
                                                SceneManager.LoadScene("BDifficultyC");
                                            else if (sceneName == "LevelBO")
                                                SceneManager.LoadScene("BDifficultyC");
                                            else if (sceneName == "LevelCA")
                                                SceneManager.LoadScene("CDifficulty");
                                            else if (sceneName == "LevelCB")
                                                SceneManager.LoadScene("CDifficulty");
                                            else if (sceneName == "LevelCC")
                                                SceneManager.LoadScene("CDifficulty");
                                            else if (sceneName == "LevelCD")
                                                SceneManager.LoadScene("CDifficulty");
                                            else if (sceneName == "LevelCE")
                                                SceneManager.LoadScene("CDifficulty");
                                            else if (sceneName == "LevelCF")
                                                SceneManager.LoadScene("CDifficultyB");
                                            else if (sceneName == "LevelCG")
                                                SceneManager.LoadScene("CDifficultyB");
                                            else if (sceneName == "LevelCH")
                                                SceneManager.LoadScene("CDifficultyB");
                                            else if (sceneName == "LevelCI")
                                                SceneManager.LoadScene("CDifficultyB");
                                            else if (sceneName == "LevelCJ")
                                                SceneManager.LoadScene("CDifficultyB");
                                            else if (sceneName == "LevelCK")
                                                SceneManager.LoadScene("CDifficultyC");
                                            else if (sceneName == "LevelCL")
                                                SceneManager.LoadScene("CDifficultyC");
                                            else if (sceneName == "LevelCM")
                                                SceneManager.LoadScene("CDifficultyC");
                                            else if (sceneName == "LevelCN")
                                                SceneManager.LoadScene("CDifficultyC");
                                            else if (sceneName == "LevelCO")
                                                SceneManager.LoadScene("CDifficultyC");
                                            else
                                                SceneManager.LoadScene("Menu");
        }
}
