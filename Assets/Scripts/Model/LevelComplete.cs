using UnityEngine;
using UnityEngine.SceneManagement;

namespace gameBall
{
    public class LevelComplete : MonoBehaviour
    {
        public void LoadNextLevel()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
        }

    }
}