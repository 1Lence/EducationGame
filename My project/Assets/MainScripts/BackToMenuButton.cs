using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainScripts
{
    public class BackToMenuButton : MonoBehaviour
    {
        // Start is called before the first frame update
        public void BackToMenu()
        {
            SceneManager.LoadSceneAsync(0);
        }
        public void QuitGame()
        { 
            Application.Quit();
        }

        public void ClosePanel()
        {
            gameObject.transform.gameObject.SetActive(false);
        }
        
    }
}
