using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour   // не понятная хуйня которая генерится сама при создании скрипта юнити ( нет подтягивает библеотеку для подсветки кода итд ) 
{
    
        
    public float movementSpeed = 1.0f;   // тут все понятно скорость бега бла бла добавляем возможность изменять скорость игроку в юнити  https://prnt.sc/unluym
    public float movementSpeedRightLeft = 1.0f;  // тут все понятно скорость влево вправо бла бла
    public FixedJoystick joystick;   // добавляем возможность в юнити прилепить скрипт для управления 
    private int life = 100;     // скрытая переменная указывет количество ХП персонажа или монстра объекта ( не путать с хп полоской)
    public Text life_state;   // добавляем хп над игроком запихиваем в конвас текст изменяем ротацию (Y) на 90 градусов

    // change speed

    void Start()
    {
        print("Start life = " + life);
        life_state.text = life.ToString();
    }

    // Update is called once per frame
    void Update()   
    {
        transform.position +=  new Vector3(movementSpeed * Time.deltaTime, 0, -(joystick.Direction.x * movementSpeedRightLeft * Time.deltaTime));
        // change speed  
    }
    public void updateLife(int puntos)    
    {
        life += puntos;
        print("Current life =" + life);
        life_state.text = life.ToString();      
        isAlive();
    }
    
    private void isAlive()
    {
        if(life <=0 )
        {
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
    }
}

// надо найти как поварачивать персонажа всего вместе с камерой влево в право выключить постоянный бег 