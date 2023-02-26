using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour
{
    public Image weaponImage;

    public Sprite[] weaponImages;

    private void Setup()
    {
        // ‚Ç‚Ì‰æ‘œ‚ğg‚¤‚©—”‚ÅŒˆ‚ß‚é
        int imageIndex = Random.Range(0, weaponImages.Length);

        //@‰æ‘œ‚ğ•ÏX‚·‚é
        weaponImage.sprite = weaponImages[imageIndex];

    }

    public void OnClickButton()
    {
        Setup();
    }

}
