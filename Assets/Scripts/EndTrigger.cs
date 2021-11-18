using UnityEngine;

namespace gameBall
{
    public class EndTrigger : MonoBehaviour
    {
        public GameManager gameManager;

        void OnTriggerEnter(Collider coll)
        {

            if (coll.name == "Player")
            {
                gameManager.CompleteLevel();
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0f;

            }

        }

    }
}