using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    public Button manaPotion;
    public Button hpPotion;
    public Button strongPotion;
    public Button speedPotion;
    public Button icePotion;
    public Button hotPotion;

    public GameObject manaText;
    public GameObject hpText;
    public GameObject strongText;
    public GameObject speedText;
    public GameObject iceText;
    public GameObject hotText;

    public GameObject manaDesc;
    public GameObject hpDesc;
    public GameObject strongDesc;
    public GameObject speedDesc;
    public GameObject iceDesc;
    public GameObject hotDesc;

    public GameObject mana;
    public GameObject hp;
    public GameObject strong;
    public GameObject speed;
    public GameObject ice;
    public GameObject hot;

    public GameObject bungaMerah;
    public GameObject jamurApi;
    public GameObject manaPotion1;
    public GameObject healthPotion;

    public GameObject bungaBiru;
    public GameObject jamurEs;
    public GameObject taringOrc;
    public GameObject buluWolf;
    public GameObject slimeMerah;
    public GameObject slimeBiru;

    public GameObject bungaIjo;
    public GameObject jamurIjo;
    public GameObject buluWolfKanan;
    public GameObject jamurApi1;
    public GameObject jamurBiru;
    // Start is called before the first frame update
    private void Start()
    {
        manaText.SetActive(false);
        hpText.SetActive(false);
        strongText.SetActive(false);
        speedText.SetActive(false);
        iceText.SetActive(false);
        hotText.SetActive(false);

        manaDesc.SetActive(false);
        hpDesc.SetActive(false);
        strongDesc.SetActive(false);
        speedDesc.SetActive(false);
        iceDesc.SetActive(false);
        hotDesc.SetActive(false);

        mana.SetActive(false);
        hp.SetActive(false);
        strong.SetActive(false);
        speed.SetActive(false);
        speed.SetActive(false);
        ice.SetActive(false);
        hot.SetActive(false);

        jamurApi.SetActive(false);
        jamurBiru.SetActive(false);

        bungaMerah.SetActive(false);
        manaPotion1.SetActive(false);
        healthPotion.SetActive(false);

        bungaBiru.SetActive(false);
        jamurEs.SetActive(false);
        taringOrc.SetActive(false);
        buluWolf.SetActive(false);
        slimeMerah.SetActive(false);
        slimeBiru.SetActive(false);

        bungaIjo.SetActive(false);
        jamurIjo.SetActive(false);
        buluWolfKanan.SetActive(false);
        jamurApi1.SetActive(false);
        jamurBiru.SetActive(false);
    }
    public void ManaPotionButton()
    {
        manaText.SetActive(true);
        hpText.SetActive(false);
        strongText.SetActive(false);
        speedText.SetActive(false);
        iceText.SetActive(false);
        hotText.SetActive(false);

        manaDesc.SetActive(true);
        hpDesc.SetActive(false);
        strongDesc.SetActive(false);
        speedDesc.SetActive(false);
        iceDesc.SetActive(false);
        hotDesc.SetActive(false);

        hp.SetActive(false);
        strong.SetActive(false);
        speed.SetActive(false);
        speed.SetActive(false);
        ice.SetActive(false);
        hot.SetActive(false);

        mana.SetActive(true);
        jamurApi.SetActive(true);
        jamurEs.SetActive(true);
        jamurIjo.SetActive(true);

        bungaMerah.SetActive(false);
        manaPotion1.SetActive(false);
        healthPotion.SetActive(false);

        bungaBiru.SetActive(false);
        taringOrc.SetActive(false);
        buluWolf.SetActive(false);
        slimeMerah.SetActive(false);
        slimeBiru.SetActive(false);

        bungaIjo.SetActive(false);
        buluWolfKanan.SetActive(false);
        jamurApi1.SetActive(false);
        jamurBiru.SetActive(false);
    }
    public void HpPotionButton()
    {
        manaText.SetActive(false);
        hpText.SetActive(true);
        strongText.SetActive(false);
        speedText.SetActive(false);
        iceText.SetActive(false);
        hotText.SetActive(false);

        manaDesc.SetActive(false);
        hpDesc.SetActive(true);
        strongDesc.SetActive(false);
        speedDesc.SetActive(false);
        iceDesc.SetActive(false);
        hotDesc.SetActive(false);

        // Menonaktifkan semua GameObject
        mana.SetActive(false);
        strong.SetActive(false);
        speed.SetActive(false);
        ice.SetActive(false);
        hot.SetActive(false);

        jamurApi.SetActive(false);
        jamurBiru.SetActive(false);

        bungaMerah.SetActive(false);
        manaPotion1.SetActive(false);
        healthPotion.SetActive(false);

        jamurEs.SetActive(false);
        taringOrc.SetActive(false);
        buluWolf.SetActive(false);
        slimeMerah.SetActive(false);
        slimeBiru.SetActive(false);

        jamurIjo.SetActive(false);
        buluWolfKanan.SetActive(false);
        jamurApi1.SetActive(false);

        // Mengaktifkan hanya GameObject yang diinginkan
        hp.SetActive(true);
        bungaMerah.SetActive(true);
        bungaBiru.SetActive(true);
        bungaIjo.SetActive(true);
    }
    public void StrongPotionButton()
    {
        manaText.SetActive(false);
        hpText.SetActive(false);
        strongText.SetActive(true);
        speedText.SetActive(false);
        iceText.SetActive(false);
        hotText.SetActive(false);

        manaDesc.SetActive(false);
        hpDesc.SetActive(false);
        strongDesc.SetActive(true);
        speedDesc.SetActive(false);
        iceDesc.SetActive(false);
        hotDesc.SetActive(false);
        // Menonaktifkan semua GameObject
        mana.SetActive(false);
        hp.SetActive(false);
        speed.SetActive(false);
        ice.SetActive(false);
        hot.SetActive(false);

        jamurApi.SetActive(false);
        jamurBiru.SetActive(false);

        bungaMerah.SetActive(false);
        healthPotion.SetActive(false);

        bungaBiru.SetActive(false);
        jamurEs.SetActive(false);
        buluWolf.SetActive(false);
        slimeMerah.SetActive(false);
        slimeBiru.SetActive(false);

        bungaIjo.SetActive(false);
        jamurIjo.SetActive(false);
        jamurApi1.SetActive(false);

        // Mengaktifkan hanya GameObject yang diinginkan
        manaPotion1.SetActive(true);
        taringOrc.SetActive(true);
        buluWolfKanan.SetActive(true);
        strong.SetActive(true);
    }
    public void SpeedPotionButton()
    {
        manaText.SetActive(false);
        hpText.SetActive(false);
        strongText.SetActive(false);
        speedText.SetActive(true);
        iceText.SetActive(false);
        hotText.SetActive(false);

        manaDesc.SetActive(false);
        hpDesc.SetActive(false);
        strongDesc.SetActive(false);
        speedDesc.SetActive(true);
        iceDesc.SetActive(false);
        hotDesc.SetActive(false);
        // Menonaktifkan semua GameObject
        mana.SetActive(false);
        hp.SetActive(false);
        strong.SetActive(false);
        ice.SetActive(false);
        hot.SetActive(false);

        jamurApi.SetActive(false);
        jamurBiru.SetActive(false);

        bungaMerah.SetActive(false);
        healthPotion.SetActive(false);

        bungaBiru.SetActive(false);
        jamurEs.SetActive(false);
        taringOrc.SetActive(false);
        buluWolfKanan.SetActive(false);
        slimeMerah.SetActive(false);
        slimeBiru.SetActive(false);

        jamurIjo.SetActive(false);
        jamurApi1.SetActive(false);

        // Mengaktifkan hanya GameObject yang diinginkan
        speed.SetActive(true);
        manaPotion1.SetActive(true);
        buluWolf.SetActive(true);
        bungaIjo.SetActive(true);
    }
    public void IcePotionButton()
    {
        manaText.SetActive(false);
        hpText.SetActive(false);
        strongText.SetActive(false);
        speedText.SetActive(false);
        iceText.SetActive(true);
        hotText.SetActive(false);

        manaDesc.SetActive(false);
        hpDesc.SetActive(false);
        strongDesc.SetActive(false);
        speedDesc.SetActive(false);
        iceDesc.SetActive(true);
        hotDesc.SetActive(false);
        // Menonaktifkan semua GameObject
        mana.SetActive(false);
        hp.SetActive(false);
        strong.SetActive(false);
        speed.SetActive(false);
        hot.SetActive(false);

        jamurApi.SetActive(false);
        bungaMerah.SetActive(false);
        manaPotion1.SetActive(false);

        bungaBiru.SetActive(false);
        jamurEs.SetActive(false);
        taringOrc.SetActive(false);
        buluWolf.SetActive(false);
        slimeMerah.SetActive(false);

        bungaIjo.SetActive(false);
        jamurIjo.SetActive(false);
        buluWolfKanan.SetActive(false);
        jamurApi1.SetActive(false);

        // Mengaktifkan hanya GameObject yang diinginkan
        ice.SetActive(true);
        healthPotion.SetActive(true);
        slimeBiru.SetActive(true);
        jamurBiru.SetActive(true);
    }
    public void HotPotionButton()
    {
        manaText.SetActive(false);
        hpText.SetActive(false);
        strongText.SetActive(false);
        speedText.SetActive(false);
        iceText.SetActive(false);
        hotText.SetActive(true);

        manaDesc.SetActive(false);
        hpDesc.SetActive(false);
        strongDesc.SetActive(false);
        speedDesc.SetActive(false);
        iceDesc.SetActive(false);
        hotDesc.SetActive(true);
        // Menonaktifkan semua GameObject
        mana.SetActive(false);
        hp.SetActive(false);
        strong.SetActive(false);
        speed.SetActive(false);
        ice.SetActive(false);

        jamurApi.SetActive(false);
        bungaMerah.SetActive(false);
        manaPotion1.SetActive(false);

        bungaBiru.SetActive(false);
        jamurEs.SetActive(false);
        taringOrc.SetActive(false);
        buluWolf.SetActive(false);
        slimeBiru.SetActive(false);

        bungaIjo.SetActive(false);
        jamurIjo.SetActive(false);
        buluWolfKanan.SetActive(false);
        jamurBiru.SetActive(false);

        // Mengaktifkan hanya GameObject yang diinginkan
        hot.SetActive(true);
        healthPotion.SetActive(true);
        slimeMerah.SetActive(true);
        jamurApi1.SetActive(true);
    }
}