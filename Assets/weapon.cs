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
        // �ǂ̉摜���g���������Ō��߂�
        int imageIndex = Random.Range(0, weaponImages.Length);

        //�@�摜��ύX����
        weaponImage.sprite = weaponImages[imageIndex];

    }

    public void OnClickButton()
    {
        Setup();
    }

}
