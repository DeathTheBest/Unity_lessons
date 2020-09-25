using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // менять сцены вешать на кнопки или условия хп =< нуля еще что-то 

public class StartButtonScript : MonoBehaviour
{   
    public string loadscene ="";

    public void onClick()
    {
        SceneManager.LoadScene(loadscene, LoadSceneMode.Single);
    }
}

// менять сцены вешать на кнопки или условия хп =< нуля еще что-то 