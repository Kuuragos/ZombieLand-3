﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC
{
<<<<<<< HEAD
    namespace Enemy
=======
    public GustoZ gz;
    public Comportamientos cz;
    public int gusto;
    
}
//en este enum se encuentra los gustos de los zombies
public enum GustoZ
{
    Cerebro,
    Dedos,
    Cuello,
    Muslo,
    Orejas,
}
//en este enum se encuentra los comportamientos que puede tomar el zombie. Idle para quedarse quieto y moving para moverse
public enum Comportamientos
{
    Idle,
    Moving,
}

public class Zombie : MonoBehaviour
{
    //aca se declaran las variables a usar y se  almacena los datos a mostrar para que no se cambien
    public DatosZombie dato;
    public int rotar;
    public float rotarZ = 3f;
    public float speedZ = 2f;
    public string gustito;

    void Start()
    {// gustito llama la funcion mensaje, tambien se le aplica el tag al gameobject para que se pueda reconocer
        gustito = Mensaje();
        gameObject.transform.tag = "ZombieNya";
       int color = Random.Range(1, 4);
       switch (color) //este switch se usa para escoger de forma random el color del zombie
        {
            case 1:
                this.GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 2:
                this.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                this.GetComponent<Renderer>().material.color = Color.magenta;
                break;
        }
       
        StartCoroutine(Wait());
    }
    //en esta corrutina se utiliza un while para verificar si mueve o deja quieto a los zombies
    IEnumerator Wait()
>>>>>>> parent of 0252aa1... fin
    {
        public class Zombie : MonoBehaviour
        {
            //aca se declaran las variables a usar y se  almacena los datos a mostrar para que no se cambien
            public DatosZombie dato;
            public int rotar;
            public float speedZ = 2f;
            public string gustito;
            public int direccion;

            void Start()
            {
<<<<<<< HEAD
                rotar = Random.Range(35, 95); //se le da la velocidad random a la rotacion del zombie
                gustito = Mensaje();// gustito llama la funcion mensaje, tambien se le aplica el tag al gameobject para que se pueda reconocer
                gameObject.transform.tag = "ZombieNya";
                int color = Random.Range(1, 4);
                switch (color) //este switch se usa para escoger de forma random el color del zombie
                {
                    case 1:
                        this.GetComponent<Renderer>().material.color = Color.cyan;
                        break;
                    case 2:
                        this.GetComponent<Renderer>().material.color = Color.green;
                        break;
                    case 3:
                        this.GetComponent<Renderer>().material.color = Color.magenta;
                        break;
                }

                StartCoroutine(Wait());
            }
            //en esta corrutina se utiliza un while para verificar si mueve o deja quieto a los zombies
            IEnumerator Wait()
            {
                while (true)
                {
                    int estado = Random.Range(0, 2);
                    switch (estado)
                    {
                        case 0:
                            dato.cz = Comportamientos.Idle;
                            break;
                        case 1:
                            dato.cz = Comportamientos.Moving;
                            direccion = Random.Range(0, 4);
                            break;
                    }
                    yield return new WaitForSeconds(5f);
                }

            }
            //esta es la funcion que se encarga de imprimir el mensaje del gusto del zombie
            public string Mensaje()
            {
                dato.gusto = Random.Range(0, 5);
                dato.gz = (GustoZ)dato.gusto;
                return "RAWWRRRR!! quiero comer " + dato.gz;
            }
            // aca se repite constantemente el movimiento del zombie
            public void Update()
            {
                if (dato.cz == Comportamientos.Moving)
                {
                    switch (direccion)
                    {
                        case 0:
                            transform.position += transform.forward * speedZ * Time.deltaTime;
                            break;
                        case 1:
                            transform.position -= transform.forward * speedZ * Time.deltaTime;
                            break;
                        case 2:
                            transform.position += transform.right * speedZ * Time.deltaTime;
                            break;
                        case 3:
                            transform.position -= transform.right * speedZ * Time.deltaTime;
                            break;
                    }

                }
                else if (dato.cz == Comportamientos.Rotating)
                {

                    transform.Rotate(transform.up * rotar * Time.deltaTime);
                }
            }
        }
        
        public struct DatosZombie
        {//en este struct se almacenan los datos de los gustos y el comportamiento del zombie
            public GustoZ gz;
            public Comportamientos cz;
            public int gusto;
    
        }
        
        public enum GustoZ
        {//en este enum se encuentra los gustos de los zombies
            Cerebro,
            Dedos,
            Cuello,
            Muslo,
            Orejas,
        }
        public enum Comportamientos
        {//en este enum se encuentra los comportamientos que puede tomar el zombie. Idle para quedarse quieto, moving para moverse y rotating para rotar
            Idle,
            Moving,
            Rotating
        }

       
=======
                case 0:
                    dato.cz = Comportamientos.Idle;
                    rotar = Random.Range(0, 2);
                    break;
                case 1:
                    dato.cz = Comportamientos.Moving;
                    break;
            }
            yield return new WaitForSeconds(5f);
        }
      
    }
    //esta es la funcion que se encarga de imprimir el mensaje del gusto del zombie
    public string Mensaje()
    {
        dato.gusto = Random.Range(0, 5);
        dato.gz = (GustoZ)dato.gusto;
        return "RAWWRRRR!! quiero comer " + dato.gz;
    }
    // aca se repite constantemente el movimiento del zombie
    public void Update()
    {
        if (dato.cz == Comportamientos.Moving)
            transform.position += transform.forward * speedZ * Time.deltaTime;
        
>>>>>>> parent of 0252aa1... fin
    }
}

