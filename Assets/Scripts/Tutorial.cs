using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Tutorial : MonoBehaviour
{
    
     // Referencia al objeto de texto
    public TextMeshProUGUI tutorialText;
    // Referencia a la imagen
    public Image infoImage;
    public Image soundImage;
    public Image recargaImage;


    // Referencias a los objetos de botón
    public Button buttonTutorial;
    public Button buttonSaltar;

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    // Función que se ejecuta al pulsar el botón
    public void OnTutorialButtonPressed()
    {
        // Desactivar el componente de TextMeshPro
        tutorialText.enabled = false;
        // Desactivar los botones
        buttonTutorial.gameObject.SetActive(false);
        buttonSaltar.gameObject.SetActive(false);

        // Activar la imagen
        infoImage.gameObject.SetActive(true);
    }
    // Función que se ejecuta al hacer clic en la pantalla
   // Función que se ejecuta al hacer clic en el panel
    public void OnPanelClick()
    {
        // Cambiar la opacidad de la imagen actual
        Color currentColor = GetComponentInChildren<Image>().color;
        currentColor.a = 0.1f;
        GetComponentInChildren<Image>().color = currentColor;

        // Activar la segunda imagen
        soundImage.gameObject.SetActive(true);
    }
}
