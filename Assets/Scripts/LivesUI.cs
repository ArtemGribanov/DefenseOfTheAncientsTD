
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public TextMeshProUGUI livesText;
   
    // Update is called once per frame
    void Update()
    {
        if (PlayerStats.Lives < 0)
            return;
        livesText.text = PlayerStats.Lives.ToString() + " LIVES";
    }
}
