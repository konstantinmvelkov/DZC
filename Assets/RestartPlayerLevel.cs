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
    [SerializeField] GameObject quitLevelFail;
    [SerializeField] GameObject startLevel;
    [SerializeField] GameObject reward;
    [SerializeField] Transform spawnReward;

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

        if (sceneName == "GrassFirst" || sceneName == "GrassSecond" || sceneName == "AutumnFirst" || sceneName == "AutumnSecond" || sceneName == "WinterFirst" || sceneName == "WinterSecond")
        {
            player.transform.position = spawnPoint.position;
            if (sceneName == "GrassFirst")
            {
                ball.transform.position = spawnBall.position;
            }
        }
        if (sceneName == "SurvivalQuestions_Level" || sceneName == "SurvivalQuestions_Level_2" || sceneName == "SurvivalQuestions_Level_3")
        {
            startLevel.SetActive(true);
            sqUI.SetActive(false);
            quitLevel.SetActive(false);
            quitLevelFail.SetActive(false);
            menu.SetActive(false);
            reward.SetActive(false);
            reward.transform.position = spawnReward.position;
        }
        if (sceneName == "Fireball_Level_1" || sceneName == "Fireball_Level_2" || sceneName == "Fireball_Level_3")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (sceneName == "RisingLava_Level_1" || sceneName == "RisingLava_Level_2" || sceneName == "RisingLava_Level_3" || sceneName == "RisingLava_Level_4" || sceneName == "RisingLava_Level_5" || sceneName == "RisingLava_Level_6")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        menu.SetActive(false);
    }
}
