using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slm : MonoBehaviour
{
    int minSayi = 0;
    int maxSayi = 100;
    int tahmin = 50;
    bool oyunBasladi = false;

    // Start is called before the first frame update
    void Start()
    {
        print("Oyun Oynayalım mı? Evetse E tuşu / Hayırsa H tuşuna bas");
    }

    // Update is called once per frame
    void Update()
    {
        if (!oyunBasladi)
        {
            Baslangic();
        }
        else
        {
            Oyun();
        }
    }

    void Baslangic()
    {
        if (Input.GetKeyDown(KeyCode.E))
        //GetKey - Klavyede tuşa sürekli basma
        //GetKeyDown - klavyeden tek sefer tuşa basarak veri alır
        //GetKeyUp - Klavyeden basılan tuştan çekme

        {
            print("Harika hadi başlayalım!");
            print("Aklından bir sayı tut ve klavyeden herhangi bir tuşa bas!");
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            print("Sea gooo aq!");
        }
        else if (Input.anyKeyDown) // yani herhangi bir tuşa basmak AnyKeyDown
        {
            //oyunburada herhangi bir tuşa basılmasıyla başlayacağı için oyunbasladıyı burada true yapıyoruz
            oyunBasladi = true;
            print("Aklından tuttuğun sayı" + tahmin + " sayısı mı?");
            print("Eğer daha büyükse YUKARI daha küçükse AŞAĞI doğruysa ENTER tşuna bas!");
        }
    }

    void Oyun()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) // UpArrow yani yukarı tuşuna bastığında
        {
            minSayi = tahmin;
            tahmin = (minSayi + maxSayi) / 2;
            print("Aklından tuttuğun sayı" + tahmin + " sayısı mı?");
            print("Eğer daha büyükse YUKARI daha küçükse AŞAĞI doğruysa ENTER tşuna bas!");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) // DownArrow yani aşağı tuşuna bastığında
        {
            maxSayi = tahmin;
            tahmin = (minSayi + maxSayi) / 2;
            print("Aklından tuttuğun sayı" + tahmin + " sayısı mı?");
            print("Eğer daha büyükse YUKARI daha küçükse AŞAĞI doğruysa ENTER tşuna bas!");
        }
        else if (Input.GetKeyDown(KeyCode.Return))  // Return yani Enter tuşuna bastığında
        {
            print("Yaşasın sayını buldum! Çak bi beşlik!");
        }
    }
}
