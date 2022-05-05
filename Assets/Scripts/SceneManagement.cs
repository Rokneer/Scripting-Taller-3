using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void Punto_1()
    {
        SceneManager.LoadScene("Punto 1");
    }
    public void Punto_2()
    {
        SceneManager.LoadScene("Punto 2");
    }
    public void Punto_3()
    {
        SceneManager.LoadScene("Punto 3");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("Main");
    }
}
