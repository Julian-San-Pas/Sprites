using UnityEngine;
using UnityEngine.SceneManagement;
public class PasoNivel : MonoBehaviour
{
    [SerializeField]
    // SceneManager es una funcionalidad de Unity que permite gestionar las escenas del juego.
    // Esta se divide en dos funcionalidades, la primera es el cambio de ecsenas por nombre o por índice SceneManager.LoadScene("Nombre de ecsena").
    // Y la seguna es por orden en el que tienen a la ora de ingresarlas ecsenas en el Build Settings SceneManager.LoadScene(0) por medio del numero de orden como un array.
    public void LoadName()
    {
        SceneManager.LoadScene("");
    }

    public void LoadNumber()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadNivle3()
    {
        SceneManager.LoadScene(3);
    }
    public void NextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



    void Start()
    {        
    }
    void Update()
    {
    }
}
