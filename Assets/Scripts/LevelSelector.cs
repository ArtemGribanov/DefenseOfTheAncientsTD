using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader sceneFader;
    public string menuSceneName = "MainMenu";

    public Button[] levelButtons;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 >levelReached)
            {
               levelButtons[i].interactable = false;
            }
        }
    }

    public void Select(string levelName)
    {
        sceneFader.FadeTo(levelName);
    }
    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            sceneFader.FadeTo(menuSceneName);
        
    }
}
