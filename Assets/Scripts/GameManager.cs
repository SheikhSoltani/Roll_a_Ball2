using UnityEngine;
using UnityEngine.SceneManagement;

namespace gameBall
{
    public class GameManager : MonoBehaviour
    {
        bool gameHasEnded = false;
        public float restartDelay = 1f;

        public GameObject completeLevelUI;

        public void CompleteLevel()
        {
            Debug.Log("Win");
            completeLevelUI.SetActive(true);
        }

        public void EndGame()
        {
            if (gameHasEnded == false)
            {
                gameHasEnded = true;
                Debug.Log("GAME OVER");
                Invoke("Restart", restartDelay);
            }
        }

        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}