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
        if (ct.A >= 30) return "Proje Y�neticisi";
        if (ct.A >= 15 && ct.A <= 25 && ct.C >= 25) return "CEO veya Genel M�d�r";
        if (ct.A >= 15 && ct.A <= 25 && ct.B >= 25) return "�� Geli�tirme Y�neticisi";


        if (ct.B >= 30) return "Veri Analizi Uzman�";
        if (ct.B >= 15 && ct.B <= 25 && ct.C >= 25) return "Teknoloji ve Bilgi Y�netimi Uzman�";
        if (ct.B >= 15 && ct.B <= 25 && ct.A >= 25) return "Risk Y�netimi Uzman�";


        if (ct.C >= 30) return "�novasyon Lideri";
        if (ct.C >= 15 && ct.C <= 25 && ct.A >= 25) return "�nsan Kaynaklar� Y�neticisi";
        if (ct.C >= 15 && ct.C <= 25 && ct.B >= 25) return "�� Geli�tirme Y�neticisi";

        return "Bu ki�i i�in uygun bir i� yok";
    }
}
