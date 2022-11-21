using UnityEngine.UI;
using UnityEngine;
using TMPro;
public class HUD : MonoBehaviour
{
    public TMP_Text textoDmg;
    public TMP_Text textotears;
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public Image heart4;
    void Update()
    {
        textoDmg.text = "Damage: " + jugador.damage.ToString();
        textotears.text = "Tears: 1 x second";
        Hurt();
    }

    void Hurt()
    {
       if(jugador.life == 3)
        {
            Destroy(heart1);
        }else if(jugador.life == 2)
        {
            Destroy(heart2);
        }else if(jugador.life == 1)
        {
            Destroy(heart3);
        }else if(jugador.life == 0)
        {
            Destroy(heart4);
        }
    }
}
