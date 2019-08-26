using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memo : MonoBehaviour
{
    int minSayi = 0;
    int maxSayi = 500;
    int tahmin = 250;

    bool oyunBasladimi = false;
    bool oyunBitti = false;
    // Start is called before the first frame update
    void Start()
    {
        print("Merhaba oyun oynayak mı? Evetse E Hayırsa H tuşuna bas!");
    }

    // Update is called once per frame
    void Update()
    {
        if (!oyunBasladimi)
        {
            Baslangic();
        }
        else
        {
            OyunBasla();
        }
    }

    void Baslangic()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Harika! Hadi başlayalım!");
            print("Aklından bir sayı tut ve başlamak için B tuşuna bas!");
        } else if (Input.GetKeyDown(KeyCode.H))
        {
            print("Küstüm oynamıyorummmm:)");

        }  else if (Input.GetKeyDown(KeyCode.B))
        {
            oyunBasladimi = true;
            print("Tuttuğun sayı" + tahmin + "sayısından büyük mü?");
            print("Büyükse YUKARI küçükse AŞAĞI yön tuşlarına bas! Doğruysa ENTER bas!");
        } else if (Input.anyKeyDown)
        {
            if (!oyunBitti)
            {
                print("Sana ne söylüyorsak ona bas! Adamın canını sıkma:)");
            }
            else
            {
                oyunBitti = true;
            }

        }
    }

    void OyunBasla()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minSayi = tahmin;
            tahmin = (maxSayi + minSayi) / 2;
            print("Tuttuğun sayı " + tahmin + " sayısı mı?");
            print("Büyükse YUKARI küçükse AŞAĞI yön tuşlarına bas! Doğruysa ENTER bas!");

        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxSayi = tahmin;
            tahmin = (maxSayi + minSayi) / 2;
            print("Tuttuğun sayı " + tahmin + " sayısı mı?");
            print("Büyükse YUKARI küçükse AŞAĞI yön tuşlarına bas! Doğruysa ENTER bas!");

        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Harika kazandım!Sayını bildim:)");
            oyunBitti = true;
            oyunBasladimi = false;
        }
    }
}
