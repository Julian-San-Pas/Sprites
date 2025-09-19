using UnityEngine;

public class Puntos : MonoBehaviour
{   public enum ItemType { Apple, Banana }
    public ItemType type = ItemType.Apple;
    public int value = 1;

    public string puntosName;
    public int puntos = 1;

  //  public bool switch;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            switch (type)
            {
                case ItemType.Apple:
                    if (GameManager.Instance != null)
                    {
                        GameManager.Instance.ScoreApple += value;
                        Debug.Log("Apple collected. Total: " + GameManager.Instance.ScoreApple);
                    }
                    break;
                case ItemType.Banana:
                    if (GameManager.Instance != null)
                    {
                        GameManager.Instance.ScoreBanana += value;
                        Debug.Log("Banana collected. Total: " + GameManager.Instance.ScoreBanana);
                    }
                    break;
            }
            Destroy(gameObject);
        }

    }
    public static Puntos Instance { get; private set; }
    private int PuntosTotales { get { return puntos; } set { puntos = value; } }
}
