using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Behavour : MonoBehaviour
{
    public Counter ct;

    public TextMeshProUGUI jobText;

    void Update()
    {
        jobText.text = Finder();
    }

    string Finder()
    {
        if (ct.A >= 30) return "Proje Yöneticisi";
        if (ct.A >= 15 && ct.A <= 25 && ct.C >= 25) return "CEO veya Genel Müdür";
        if (ct.A >= 15 && ct.A <= 25 && ct.B >= 25) return "Ýþ Geliþtirme Yöneticisi";


        if (ct.B >= 30) return "Veri Analizi Uzmaný";
        if (ct.B >= 15 && ct.B <= 25 && ct.C >= 25) return "Teknoloji ve Bilgi Yönetimi Uzmaný";
        if (ct.B >= 15 && ct.B <= 25 && ct.A >= 25) return "Risk Yönetimi Uzmaný";


        if (ct.C >= 30) return "Ýnovasyon Lideri";
        if (ct.C >= 15 && ct.C <= 25 && ct.A >= 25) return "Ýnsan Kaynaklarý Yöneticisi";
        if (ct.C >= 15 && ct.C <= 25 && ct.B >= 25) return "Ýþ Geliþtirme Yöneticisi";

        return "Bu kiþi için uygun bir iþ yok";
    }
}
