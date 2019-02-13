using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RootMenu : MonoBehaviour
{
    public List<GameObject> Menus = new List<GameObject>();

    public List<Text> textForTranslate = new List<Text>();

    public List<Font> fonts = new List<Font>();


    private void Start()
    {
        if (PlayerPrefs.GetInt("Languige") == 0)
        {
            BtnEnglish();
        }

        if (PlayerPrefs.GetInt("Languige") == 1)
        {
            BtnUkraine();
        }

        if (PlayerPrefs.GetInt("Languige") == 2)
        {
            BtnRussian();
        }
    }

    public void BtnPlay()   // Chose level
    {
        Menus[0].SetActive(false);
        Menus[2].SetActive(true);
    }

    public void BtnOptions()
    {
        Menus[0].SetActive(false);
        Menus[1].SetActive(true);
    }

    public void BtnMusic()
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
        }
        else
        {
            AudioListener.pause = true;
        }
    }

    public void BtnExit()
    {
        Application.Quit();
    }

    public void BtnAchiv()   // Achivment
    {

    }

    public void BtnRecords()   // Records
    {

    }

    public void BtnLike()  // Go to game for like
    {

    }


    public void BtnBack()
    {
        Menus[1].SetActive(false);
        Menus[2].SetActive(false);
        Menus[3].SetActive(false);
        Menus[0].SetActive(true);
    }


    //Languige
    public void BtnLanguige()
    {
        Menus[0].SetActive(false);
        Menus[1].SetActive(false);
        Menus[2].SetActive(false);
        Menus[3].SetActive(true);
    }

    public void BtnEnglish()
    {
        textForTranslate[0].text = "Play";
        textForTranslate[0].font = fonts[0];
        textForTranslate[1].text = "Options";
        textForTranslate[1].font = fonts[0];
        textForTranslate[2].text = "Exit";
        textForTranslate[2].font = fonts[0];
        textForTranslate[3].text = "Music";
        textForTranslate[3].font = fonts[0];
        textForTranslate[4].text = "Languige";
        textForTranslate[4].font = fonts[0];
        textForTranslate[5].text = "Back";
        textForTranslate[5].font = fonts[0];
        textForTranslate[6].text = "Back";
        textForTranslate[6].font = fonts[0];
        textForTranslate[7].text = "Back";
        textForTranslate[7].font = fonts[0];
        textForTranslate[8].text = "Level Select";
        textForTranslate[8].font = fonts[0];
        textForTranslate[9].text = "Options";
        textForTranslate[9].font = fonts[0];

        PlayerPrefs.SetInt("Languige", 0);
    }

    public void BtnUkraine()
    {
        textForTranslate[0].text = "Грати";
        textForTranslate[0].font = fonts[1];
        textForTranslate[1].text = "Опції";
        textForTranslate[1].font = fonts[1];
        textForTranslate[2].text = "Вихід";
        textForTranslate[2].font = fonts[1];
        textForTranslate[3].text = "Музика";
        textForTranslate[3].font = fonts[1];
        textForTranslate[4].text = "Мова";
        textForTranslate[4].font = fonts[1];
        textForTranslate[5].text = "Назад";
        textForTranslate[5].font = fonts[1];
        textForTranslate[6].text = "Назад";
        textForTranslate[6].font = fonts[1];
        textForTranslate[7].text = "Назад";
        textForTranslate[7].font = fonts[1];
        textForTranslate[8].text = "Виберіть Рівень";
        textForTranslate[8].font = fonts[1];
        textForTranslate[9].text = "Опції";
        textForTranslate[9].font = fonts[1];

        PlayerPrefs.SetInt("Languige", 1);
    }

    public void BtnRussian()
    {
        textForTranslate[0].text = "Играть";
        textForTranslate[0].font = fonts[1];
        textForTranslate[1].text = "Настройки";
        textForTranslate[1].font = fonts[1];
        textForTranslate[2].text = "Выход";
        textForTranslate[2].font = fonts[1];
        textForTranslate[3].text = "Музыка";
        textForTranslate[3].font = fonts[1];
        textForTranslate[4].text = "Язык";
        textForTranslate[4].font = fonts[1];
        textForTranslate[5].text = "Назад";
        textForTranslate[5].font = fonts[1];
        textForTranslate[6].text = "Назад";
        textForTranslate[6].font = fonts[1];
        textForTranslate[7].text = "Назад";
        textForTranslate[7].font = fonts[1];
        textForTranslate[8].text = "Выберите Уровень";
        textForTranslate[8].font = fonts[1];
        textForTranslate[9].text = "Настройки";
        textForTranslate[9].font = fonts[1];

        PlayerPrefs.SetInt("Languige", 2);
    }
    //
}
