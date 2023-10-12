using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public TextMeshProUGUI lifeText;
    public int lives = 10;  

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            lives -= 1;
            lifeText.text = lives.ToString();

            if (lives <= 0)
            {
                SceneManager.LoadScene("Perdio");
            }
        }
    }
}