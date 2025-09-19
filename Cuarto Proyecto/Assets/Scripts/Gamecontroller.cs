using TMPro;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public TextMeshProUGUI PointsApple;
    public TextMeshProUGUI PointsBanana;

    public Timer timer;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Respawn();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (GameManager.Instance != null)
        {
            int apples = GameManager.Instance.ScoreApple;
            int bananas = GameManager.Instance.ScoreBanana;

            PointsApple.text = apples.ToString();
            PointsBanana.text = bananas.ToString();
        }
    }

    public void Respawn()
    {
        player.transform.position = new Vector3(0, 0, 0);
    }
    public void EndGame()
    {
        timer.enabled = false;
    }
    public void AddTimer()
    {
        timer.TimerStart();
    }
}
