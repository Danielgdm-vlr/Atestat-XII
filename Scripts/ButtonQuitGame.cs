using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuitGame : MonoBehaviour
{
    public void Quit()
    {
        /* Debug.Log("has quit game");  
        Application.Quit();, functia merge in momentul in care jocul este facut complet.
        In timp ce jocul este inca in dezvoltare, ca sa pot vedea daca acesta functie merge am folosit 
        Debug.Log care scrie in consola mesajul "has quit game" daca scriptul a functionat.*/
        Application.Quit();
    }
}
