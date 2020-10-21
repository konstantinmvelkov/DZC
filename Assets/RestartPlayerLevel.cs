using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPlayerLevel : MonoBehaviour
{
    //Jumping Levels
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject player;
    //Jumping level 1
    [SerializeField] Transform spawnBall;
    [SerializeField] GameObject ball;

    //SurvivalQuestions_Level
    [SerializeField] GameObject sqUI;
    [SerializeField] GameObject quitLevel;
    [SerializeField] GameObject startLevel;

    //Vulcano_Level
    [SerializeField] FireballSpawner fireballSpawner;

    //All levels
    [SerializeField] GameObject menu;

    public void Restart()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();
        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Jumping" || sceneName == "Jumping2" || sceneName == "Jumping3" || sceneName == "Jumping4" || sceneName == "Jumping5" || sceneName == "Jumping6")
        {
            player.transform.position = spawnPoint.position;
            if (sceneName == "Jumping")
            {
                ball.transform.position = spawnBall.position;
            }
        }
        if (sceneName == "SurvivalQuestions_Level")
        {
            startLevel.SetActive(true);
            sqUI.SetActive(false);
            quitLevel.SetActive(false);
        }
        if (sceneName == "Vulcano_Level")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (sceneName == "RisingLava_Level")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        menu.SetActive(false);
    }
}
