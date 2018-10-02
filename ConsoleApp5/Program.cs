using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Peio.");
            Console.ReadLine();

            Console.WriteLine(2 + 2);
            Console.ReadLine();

            Console.WriteLine(8 / 2);
            Console.ReadLine();
            
            Console.WriteLine(-5 + (8 * 6));


            Console.WriteLine((55 + 9) % 9);

            Console.WriteLine(20 + (-3 * 5) / 8);

            Console.WriteLine((5 + (15 / (3 * 2)) - 8) % 3);
            Console.ReadLine();

               int n1;
               int n2;
               Console.WriteLine("Introduce un número: ");
               n1 = Int32.Parse(Console.ReadLine());
               Console.WriteLine("Introduce otro número: ");
                n2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("El resultado de multiplicar " + n1 + " por " + n2 + " es " + (n1 * n2));

                float num1;
                float num2;
                Console.WriteLine("Introduce un número: ");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce otro número: ");
                num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("El resultado de multiplicar " + num1 + " por " + num2 + " es " + (num1 * num2));
                Console.WriteLine("El resultado de sumar " + num1 + " y " + num2 + " es " + (num1 + num2));
                Console.WriteLine("El resultado de restar " + num1 + " y " + num2 + " es " + (num1 - num2));
                Console.WriteLine("El resultado de dividir " + num1 + " entre " + num2 + " es " + (num1 / num2));
                Console.WriteLine("El resto de la división entre " + num1 + " y " + num2 + " es " + (num1 % num2));

                int numMulti;
                Console.WriteLine("Introduce un número.");
                numMulti = Int32.Parse(Console.ReadLine());
                Console.WriteLine(numMulti + " x 1 = " + numMulti * 1);
                Console.WriteLine(numMulti + " x 2 = " + numMulti * 2);
                Console.WriteLine(numMulti + " x 3 = " + numMulti * 3);
                Console.WriteLine(numMulti + " x 4 = " + numMulti * 4);
                Console.WriteLine(numMulti + " x 5 = " + numMulti * 5);
                Console.WriteLine(numMulti + " x 6 = " + numMulti * 6);
                Console.WriteLine(numMulti + " x 7 = " + numMulti * 7);
                Console.WriteLine(numMulti + " x 8 = " + numMulti * 8);
                Console.WriteLine(numMulti + " x 9 = " + numMulti * 9);
                Console.WriteLine(numMulti + " x 10 = " + numMulti * 10);

                Console.WriteLine("El resultado de  ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)) es " + ((25.5 * 3.5 - (3.5 * 3.5)) / (40.5 - 4.5)));

                Console.WriteLine("El resultado de (4.0 * (1 - (1.0/3) + (1.0/5) - (1.0/7) + (1.0/9) - (1.0/11))) es " + (4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11))));

                float radio;
                const double PI = 3.141593;
                Console.WriteLine("Introduce un número. ");
                radio = Int32.Parse(Console.ReadLine());
                Console.WriteLine("El área del círculo es " + (PI * (radio * radio)));
                Console.WriteLine("El perímetro del círculo es " + (2 * radio * PI));

                int primNum;
                int secNum;
                int tercNum;
                Console.WriteLine("Introduzca un número.");
                primNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca un número.");
                secNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca un número.");
                tercNum = Int32.Parse(Console.ReadLine());
                Console.WriteLine("La media de los tres números es " + ((primNum + secNum + tercNum) / 3));

                int altura;
                int anchura;
                Console.WriteLine("Altura de cuadrado. ");
                altura = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anchura del cuadrado. ");
                anchura = Int32.Parse(Console.ReadLine());
                Console.WriteLine("El perímetro del cuadrado es " + (2 * (altura + anchura)));
                Console.WriteLine("El área del cuadrado es " + (altura * anchura));

                int var1;
                int var2;
                Console.WriteLine("Escribe un número. ");
                var1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Escribe otro. ");
                var2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("El valor del primer número es " + var2 + " y el valor del segundo es " + var1);

            int numero1;
            int numero2;
            Console.WriteLine("Dame un número. ");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Venga, dame otro (diferente al primero). ");
            numero2 = Int32.Parse(Console.ReadLine());
            if (numero1 != numero2)
            {
                Console.WriteLine(numero1 + " != " + numero2);
            }
            if (numero1 < numero2)
            {
                Console.WriteLine(numero1 + " < " + numero2);
            }
            else
            {
                Console.WriteLine(numero2 + " < " + numero1);
            }
            if (numero1 <= numero2)
            {
                Console.WriteLine(numero1 + " <= " + numero2);
            }
            else
            {
                Console.WriteLine(numero2 + " <= " + numero1);
            }
            Console.ReadLine();


            //Pendiente comparación numeros

            int numero;
                Console.WriteLine("Introduce un número de 3 digitos. ");
                numero = Int32.Parse(Console.ReadLine());
                int digito1 = numero % 10;
                int digito2 = (numero % 100 - digito1) / 10;
                int digito3 = numero / 100;
                Console.WriteLine("Digito1 es: " + digito1);
                Console.WriteLine("Digito2 es: " + digito2);
                Console.WriteLine("Digito3 es: " + digito3);
                Console.WriteLine("La suma de los dígitos del número " + numero + " es " + (numero % 10 + (numero % 100 - digito1) / 10 + numero / 100));
                Console.ReadLine();

                int digito;
                Console.WriteLine("Dame un dígito. ");
                digito = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Primero uno, luego dos, después tres y sumamos al final. ");
                Console.WriteLine(digito);
                Console.WriteLine(digito * 11);
                Console.WriteLine(digito * 111);
                Console.WriteLine("El total es " + (digito + digito * 11 + digito * 111));
                Console.ReadLine();

            //Escribe un programa que calcule el resto de dividir dos números sin utilizar el operador de división de resto (%)
            int dig1;
            int dig2;
            Console.WriteLine("Dame un número. ");
            dig1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame otro número. ");
            dig2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("El resto de dividir " + dig1 + " y " + dig2 + " es: ");
            Console.WriteLine(-(((dig1 / dig2) * dig2 - dig1)));
            Console.ReadLine();

            //Escribe un programa que le pida al usuario un número de pulgadas y lo convierta a metros (una pulgada son 0.0254 metros)

            int pulgadas;
            const double conver = 0.0254;
                Console.WriteLine("Dame una medida en pulgadas. Intentare pasarla a metros. ");
                pulgadas = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Eso son " + pulgadas * conver + " metros. ");
                Console.ReadLine();


                //Escribe un programa que pida un número de minutos y muestre cuantos años y días son

                float minutos;
                Console.WriteLine("Dime un número de minutos, y lo pasaremos a días primero y a años después. ");
                minutos = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Eso son " + (minutos / 60 / 24) + " días, o " + minutos / 60 / 24 / 365 + " años ");
                Console.ReadLine();


                //Escribe un programa que pida una distancia (en metros), y el tiempo tardado (como tres números: horas, minutos y segundos)
                //y que muestre la velocidad en metros por segundo y kilómetros por hora.

                float metros;
                float hour;
                float min;
                float sec;
                Console.WriteLine("¿Qué distancia has recorrido? ");
                metros = Int32.Parse(Console.ReadLine());
                Console.WriteLine("¿En cuántas horas? ");
                hour = Int32.Parse(Console.ReadLine());
                Console.WriteLine("¿En cuántos minutos? ");
                min = Int32.Parse(Console.ReadLine());
                Console.WriteLine("¿Y segundos? ");
                sec = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Has recorrido " + metros * sec + " metros por segundo, o lo que es lo mismo, " + (metros / 1000) * hour + " kilómetros por hora. ");
                Console.ReadLine();


            /**Escribe un programa que pida al usuario 3 números. 
             * Si el resultado de la suma de los dos primeros es igual al tercer número, mostrarlo en pantalla, 
             * sino mostrar que el tercero no es la suma de los dos anteriores.
             **/

            int primerNum;
            int segundoNum;
            int tercerNum;
            Console.WriteLine("Dame tres números. ");
            primerNum = Int32.Parse(Console.ReadLine());
            segundoNum = Int32.Parse(Console.ReadLine());
            tercerNum = Int32.Parse(Console.ReadLine());
            





















            
        }
    }
}
