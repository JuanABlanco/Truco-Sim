using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager InstanciaCompartida; //Instancia del patron Singleton

    public static GameManager Instance { get { return InstanciaCompartida; } } //Getter que garantiza que solo se obtenga la instancia compartida

    public Deck ActiveDeck;

    public List<Player> Players;

    void Awake()
    {
        // En caso de que se instancie nuevamente esta clase, este if destruye el objeto para que quede inutilizable la nueva instancia 
        if (InstanciaCompartida != null && InstanciaCompartida != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            // Se asigna la primera instancia a esta clase
            InstanciaCompartida = this;
        }
        
    }
}
