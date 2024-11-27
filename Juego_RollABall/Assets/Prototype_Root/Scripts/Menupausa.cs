using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menupausa : MonoBehaviour
{

    public GameObject Grupo_menu_pausa;
    public bool Pausa = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pausa == false)
            {
                Grupo_menu_pausa.SetActive(true);
                Pausa = true;

                Time.timeScale = 0;
              
            }
            else if (Pausa == true)
            {
                Restart();
            }
        }
    }
    public void Restart()
    {
        Grupo_menu_pausa.SetActive(false);
        Pausa = false;

        Time.timeScale = 1;
      
    }

    public void irAlMenu(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }
    
}
