using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
