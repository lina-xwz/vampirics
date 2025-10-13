using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public static bool GamePause = false;

    [SerializeField] private GameObject Menu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (GamePause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
    }

    void Resume()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }

    void Pause()
    {
        Menu.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }
}
