using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private float globalTime;

    public int scoreApple=0;
    public int scoreBanana=0;


    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TotalTime(float timeScene)
    {
        globalTime += timeScene;
    }

    public void TotalBanana(float Banana)
    {
        globalTime += Banana;
    }

    public void TotalApple(float Apple)
    {
        globalTime += Apple;
    }

    private float GlobalTime {  get { return globalTime; } set { globalTime = value; } }

    //public float GlobalTime1 { get => globalTime; set => globalTime = value; }
    public int ScoreApple { get => scoreApple; set => scoreApple = value; }
    public int ScoreBanana { get => scoreBanana; set => scoreBanana = value; }

    public int player;

    public GameManager(float globalTime, int scoreApple, int scoreBanana)
    {
        this.globalTime = globalTime;
        this.scoreApple = scoreApple;
        this.scoreBanana = scoreBanana;
    }



    void Start()
    {
    }
    void Update()
    {        
    }
}
