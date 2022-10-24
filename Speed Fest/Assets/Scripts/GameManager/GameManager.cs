using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
#region SingletonPart
    public static GameManager _gamemanager;

    public void Awake()
    {
        if (_gamemanager == null)
        {
            _gamemanager = this;
        }
    }
#endregion



#region Top To Start
    public void TopToStart()
    {
        if (Input.GetMouseButton(0))
        {
            isGameStart = true;

            StartText.gameObject.SetActive(false);
            return;
        }
    }
#endregion


    public int Score;

    public TMP_Text TextScore;

    void Start()
    {
        TextScore.text = "Score:" + Score;
    }

    public void ScorePoint(int point)
    {
        Score+=point;
    }

    public bool isGameStart = false;

    public TMP_Text StartText;


#region NextLevel Part
    [SerializeField]
    private GameObject NextLevelUI;

    public void CallNextLevelUI()
    {
        NextLevelUI.gameObject.SetActive(true);
    }

    public void NextLevelTimer() //call here
    {
        Invoke("CallNextLevelUI", 2f);
    }

    public void NextScene()
    {
        if (
            SceneManager.GetActiveScene().buildIndex + 1 ==
            SceneManager.sceneCountInBuildSettings
        )
        {
            SceneManager.LoadScene(sceneName: "Level1");
        }
        else
        {
            SceneManager
                .LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
#endregion


    private void Update()
    {
        TopToStart();
    }
}
