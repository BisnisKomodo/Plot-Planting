using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private WelfareManager welfareManager;
    private EntertaintmentManager entertaintmentManager;
    private EducationManager educationManager;

    void Start()
    {
        welfareManager = FindObjectOfType<WelfareManager>();
        entertaintmentManager = FindObjectOfType<EntertaintmentManager>();
        educationManager = FindObjectOfType<EducationManager>();
    }

    public void CheckGameOver()
    {
        if (welfareManager.currentwelfare <= 0 || 
            entertaintmentManager.currententertaintment <= 0 ||
            educationManager.currenteducation <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene("GameOver");
    }
}
