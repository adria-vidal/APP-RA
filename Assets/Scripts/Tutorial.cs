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
    
    // Referencia a las imágenes
    public Image infoImage;
    public Image soundImage;
    public Image recargaImage;

    // Referencias a los objetos de botón
    public Button buttonTutorial;
    public Button buttonSiguiente;
    public Button buttonSaltar;

    private int currentImage = 0;

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Función que se ejecuta al pulsar el botón "Tutorial"
    public void OnTutorialButtonPressed()
    {
        tutorialText.enabled = false;
        buttonSaltar.gameObject.SetActive(false);
        buttonTutorial.gameObject.SetActive(false);
        buttonSiguiente.gameObject.SetActive(true);
        infoImage.gameObject.SetActive(true);
    }

    // Función que se ejecuta al pulsar el botón "Siguiente"
    public void OnSiguienteButtonPressed()
    {
        // Desactivar la imagen actual
        if (currentImage == 0)
        {
            infoImage.gameObject.SetActive(false);
            // Cambiar la opacidad de la imagen siguiente
            Color currentColor = soundImage.color;
            currentColor.a = 0.8f;
            soundImage.color = currentColor;
            soundImage.gameObject.SetActive(true);
        }
        else if (currentImage == 1)
        {
            soundImage.gameObject.SetActive(false);
            // Cambiar la opacidad de la imagen siguiente
            Color currentColor = recargaImage.color;
            currentColor.a = 0.8f;
            recargaImage.color = currentColor;
            recargaImage.gameObject.SetActive(true);
            buttonSiguiente.GetComponentInChildren<TextMeshProUGUI>().text = "Continuar";
        }
        else
        {
            LoadNextScene();
        }

        // Incrementar el índice de imagen actual
        currentImage++;
    }
    
}
