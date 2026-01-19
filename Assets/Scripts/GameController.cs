using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    //Este script es para el GameObject gamecontroler

    [SerializeField] private TMP_Text _coincount;
    
    //Se inicia desde cero
    private int Coin = 0;
    
    //Se hace la suma y convierte esta en texto opara que se puede observar el 
    //cambio en la pantalla.
    public void UpdateCoins()
    {
        Coin++;
        _coincount.text = Coin.ToString();
    }
}
