using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "GameManager", menuName = "Scriptable Objects/Game Manager")]
public class GameManager : ScriptableObject
{
    [SerializeField]
    private GameObject _pauseMenuPrefab;
    private GameObject _pauseMenu;

    public void PauseGame()
    {
        if (_pauseMenu == null)
            _pauseMenu = Instantiate(_pauseMenuPrefab);
        else
            _pauseMenu.SetActive(true);

        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void TogglePause()
    {
        if (_pauseMenu != null && _pauseMenu.activeInHierarchy)
            UnpauseGame();
        else
            PauseGame();
    }

    public void ReloadScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
