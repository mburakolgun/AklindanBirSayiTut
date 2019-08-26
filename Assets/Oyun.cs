using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyun : MonoBehaviour
{
    int minSayi = 0;
    int maxSayi = 100;
    int tahmin = 50;

    bool oyunBasladi = false;

    // Start is called before the first frame update
    void Start()
    {
        print("Oyun oynayalım mı? Evetse E, Hayırsa H tuşuna bas!");
    }

    // Update is called once per frame
    void Update()
    {
        if (!oyunBasladi)
        {
            Basla();
        }
        else
        {
            Oyunda();
        }

    }

    void Basla()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("Hadi başlayalım!");
            print("Aklından bir sayı tut ve B tuşuna bas!");
        } else if (Input.GetKeyDown(KeyCode.H))
        {
            print("Valla sen bilirsin!");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            oyunBasladi = true;
            print("Tuttuğun sayı" + tahmin + " rakamı mı?");
            print("Yüksekse YUKARI düşükse AŞAĞI tuşlarına bas!");
        }
        else if (Input.anyKeyDown)
        {
            print("Sana söylenen tuşlara bas! Mallık yapma:)");
        }
    }

    void Oyunda()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) //yani yukarı ok
        {
            minSayi = tahmin;
            tahmin = (maxSayi + minSayi) / 2;
            print("Tuttuğun sayı" + tahmin + " rakamı mı?");
            print("Yüksekse YUKARI düşükse AŞAĞI tuşlarına bas!");
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) //yani aşağı ok
        {
            maxSayi = tahmin;
            tahmin = (maxSayi + minSayi) / 2;
            print("Tuttuğun sayı" + tahmin + " rakamı mı?");
            print("Yüksekse YUKARI düşükse AŞAĞI tuşlarına bas!");
        } else if (Input.GetKeyDown(KeyCode.Return)) //yani enter tuşu
        {
            print("Hahahhaa sayını buldum kiii!");
        }
    }
}
