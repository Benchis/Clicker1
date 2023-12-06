using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text clicksText;
    int _clicks;

    public TMP_Text grandmaCountText;
    public int grandmas;
    public int grandmaCost;
    public int grandmaCPS;

    public int Clicks
    {
        get { return _clicks; }
        set
        {
            _clicks = value;
            clicksText.text = _clicks.ToString();
        }
    }

    void Save()
    {
        PlayerPrefs.SetInt("clicks",_clicks);
        PlayerPrefs.SetInt("grandmas",grandmas);
        PlayerPrefs.SetInt("grandmaCost", grandmaCost);

    }

    void Load()
    {
        Clicks = PlayerPrefs.GetInt("clicks");
        grandmas = PlayerPrefs.GetInt("grandmas");
        grandmaCost = PlayerPrefs.GetInt("grandmaCost",10);
    }

    void Start()
    {
        Load();
        InvokeRepeating("Save",3f,3f);
        InvokeRepeating("Work",1f,1f);
    }

    void OnApplicationQuit()
    {
        Save();
    }

    public void Buy()
    {
        if (Clicks >= grandmaCost)
        {
            Clicks -= grandmaCost;
            grandmas++;
            grandmaCost = (int)(grandmaCost * 1.5f);
            grandmaCountText.text = grandmas.ToString();
        }
    }

    void Work()
    {
        Clicks += grandmas * grandmaCPS;
    }
}