using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuActivator : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        CheckForPause();
        if (pauseMenu.activeInHierarchy == false)
        {
            Time.timeScale = 1.0f;
        }
    }

    private void CheckForPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.activeInHierarchy == false)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
