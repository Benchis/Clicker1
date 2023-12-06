using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text clicksText;

    int _clicks;
    public int Clicks
    {
        get { return _clicks; }
        set
        {
            _clicks = value;
            clicksText.text = _clicks.ToString();
        }
    }
}