using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public Button restartButton; // Перетаскиваешь кнопку сюда через инспектор

    void Start()
    {
        // Назначаем метод Restart() при клике
        restartButton.onClick.AddListener(Restart);
    }

    public void Restart()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
