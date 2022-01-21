using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 
    public void PlayGame () //Kod som tar player till nästa scen av spelet (main meny till spelet) //Maria
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Entrance_Room", LoadSceneMode.Additive);
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
        //SceneManager.UnloadSceneAsync("main menue");



    }

    public void QuitGame() //Avslutar spelet i main meny //Maria
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
