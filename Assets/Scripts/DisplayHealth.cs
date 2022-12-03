using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DisplayHealth : MonoBehaviour
{

    int health = 100;
    TextMeshProUGUI healthLabel;
    // Start is called before the first frame update
    void Start()
    {
        healthLabel = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateHealth()
    {
        health -= 10;
        healthLabel.text = health.ToString();

        if (health == 0)
        {
            SceneManager.LoadScene("endScene");
        }
    }
}
