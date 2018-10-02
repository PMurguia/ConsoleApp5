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


            Pendiente comparación numeros

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

            Escribe un programa que calcule el resto de dividir dos números sin utilizar el operador de división de resto(%)
            int dig1;
            int dig2;
            Console.WriteLine("Dame un número. ");
            dig1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Dame otro número. ");
            dig2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("El resto de dividir " + dig1 + " y " + dig2 + " es: ");
            Console.WriteLine(-(((dig1 / dig2) * dig2 - dig1)));
            Console.ReadLine();

            Escribe un programa que le pida al usuario un número de pulgadas y lo convierta a metros(una pulgada son 0.0254 metros)

            int pulgadas;
            const double conver = 0.0254;
            Console.WriteLine("Dame una medida en pulgadas. Intentare pasarla a metros. ");
            pulgadas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Eso son " + pulgadas * conver + " metros. ");
            Console.ReadLine();


            Escribe un programa que pida un número de minutos y muestre cuantos años y días son

            float minutos;
            Console.WriteLine("Dime un número de minutos, y lo pasaremos a días primero y a años después. ");
            minutos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Eso son " + (minutos / 60 / 24) + " días, o " + minutos / 60 / 24 / 365 + " años ");
            Console.ReadLine();


            Escribe un programa que pida una distancia(en metros), y el tiempo tardado(como tres números: horas, minutos y segundos)
              y que muestre la velocidad en metros por segundo y kilómetros por hora.

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
            if (primerNum + segundoNum == tercerNum)
            {
                Console.WriteLine("La suma de " + primerNum + " y " + segundoNum + " es igual a " + tercerNum);
            }
            else
            {
                Console.WriteLine("La suma de " + primerNum + " y " + segundoNum + " no es igual a " + tercerNum);
            }
            Console.ReadLine();

            Una hora = 3.600 segundos

            int segundos;
            Console.WriteLine("Pasemos segundos a horas, minutos y segundos. ");
            segundos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Eso son " + segundos / 3600 + " horas, " + (segundos - 3600) / 60 + " minutos y " + ((segundos - 3600) % 60) + " segundos.");
            Console.ReadLine();




            Escribe un programa que pida al usuario tres números y que diga si uno de ellos es 20 menos que uno de los otros.

            int otroNum1;
            int otroNum2;
            int otroNum3;
            Console.WriteLine("Dame tres números diferentes entre si. ");
            otroNum1 = Int32.Parse(Console.ReadLine());
            otroNum2 = Int32.Parse(Console.ReadLine());
            otroNum3 = Int32.Parse(Console.ReadLine());

            if (otroNum1 == otroNum2 - 20 || otroNum2 == otroNum1 - 20)
            {
                if (otroNum1 == otroNum2 - 20)
                {
                    Console.WriteLine(otroNum2 + " es 20 menos que " + otroNum1);
                }
                else if (otroNum2 == otroNum1 - 20)
                {
                    Console.WriteLine(otroNum1 + " es 20 menos que " + otroNum2);
                }
                else
                {
                    Console.WriteLine("Gracias. ");
                }
            }
            if (otroNum2 == otroNum3 - 20 || otroNum3 == otroNum2 - 20)
            {
                if (otroNum2 == otroNum3 - 20)
                {
                    Console.WriteLine(otroNum3 + " es 20 menos que " + otroNum2);
                }
                else if (otroNum3 == otroNum2 - 20)
                {
                    Console.WriteLine(otroNum2 + " es 20 menos que " + otroNum3);
                }
                else
                {
                    Console.WriteLine("Gracias. ");
                }
            }
            if (otroNum3 == otroNum1 - 20 || otroNum1 == otroNum3 - 20)
            {
                if (otroNum3 == otroNum1 - 20)
                {
                    Console.WriteLine(otroNum1 + " es 20 menos que " + otroNum3);
                }
                else if (otroNum1 == otroNum3 - 20)
                {
                    Console.WriteLine(otroNum3 + " es 20 menos que " + otroNum1);
                }
                else
                {
                    Console.WriteLine("Gracias. ");
                }
            }
            else
            {
                Console.WriteLine("Gracias. ");
            }
            Console.ReadLine();


            /**Escribe un programa que pida dos valores del usuario y
            *Si los dos valores son iguales muestre 0
            *Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
            *Si no que muestre el más grande de los dos
            **/

            int otroValor1;
            int otroValor2;
            Console.WriteLine("Dame dos números. ");
            otroValor1 = Int32.Parse(Console.ReadLine());
            otroValor2 = Int32.Parse(Console.ReadLine());
            if (otroValor1 == otroValor2) //Primer if, para determinar si ambos valores son iguales
            {
                Console.WriteLine("Los restos son iguales, por lo tanto 0"); //En caso afirmativo, nos dará esto en pantalla;
            }
            else
            {
                Console.WriteLine("Los restos no son iguales. "); //De lo contrario, saldrá esto.
            }
            if (otroValor1 % 6 == otroValor2 % 6) //Segundo if, para determinar el resto de menor valor
            {
                if (otroValor1 % 6 <= otroValor2 % 6) //si resto de primer valor es menor
                {
                    Console.WriteLine(otroValor1); //Saldrá esta operación
                }
                else
                {
                    Console.WriteLine(otroValor2); //Si no, saldrá esta otra
                }
            }
            if (otroValor1 % 6 != otroValor2 % 6) //Tercer if para determinar el mayor valor en caso de no coincidir los restos
            {
                if (otroValor1 % 6 >= otroValor2 % 6) //si resto de primer valor mayor que el segundo,
                {
                    Console.WriteLine(otroValor1); //saldrá esta operación.
                }
                else //Si el resto de mayor valor es el segundo
                {
                    Console.WriteLine(otroValor2); // Saldrá esta operación.
                }
            }
            Console.ReadLine();


            //Escribe un programa que pida dos números enteros entre 25 y 75 y que diga si hay un dígito en común entre los dos números.


            int numDig1; //Variable primer número
            int numDig2; //Variable segundo número


            Console.WriteLine("Dame dos números del 25 al 75 (ambos incluídos. "); //Pedimos dos dígitos
            numDig1 = Int32.Parse(Console.ReadLine());
            numDig2 = Int32.Parse(Console.ReadLine());

            int numDig12 = numDig1 % 10; //Calculamos de nx, la X
            int numDig11 = ((numDig1 - numDig12) / 10); // de nx, la N
            int numDig22 = numDig2 % 10; //de yz, la Z
            int numDig21 = ((numDig2 - numDig22) / 10); //de yz, la Y


            if (numDig1 == numDig2) // Si las variables iniciales coinciden en valor
            {
                Console.WriteLine("Todos los números coinciden. ");
            }
            else //Si no coinciden, vamos dígito a dígito
            {
                if (numDig11 == numDig21) // Comparamos dígitos de los dos números
                {
                    Console.WriteLine(numDig1 + " y " + numDig2 + " tienen en común el número " + numDig11);
                }

                if (numDig11 == numDig22) // Comparamos dígitos de los dos números
                {
                    Console.WriteLine(numDig1 + " y " + numDig2 + " tienen en común el número " + numDig11);
                }
                if (numDig12 == numDig21) // Comparamos dígitos de los dos números
                {
                    Console.WriteLine(numDig1 + " y " + numDig2 + " tienen en común el número " + numDig12);
                }
                if (numDig12 == numDig22) // Comparamos dígitos de los dos números
                {
                    Console.WriteLine(numDig1 + " y " + numDig2 + " tienen en común el número " + numDig12);
                }
            }
            if (numDig11 != numDig21 && numDig11 != numDig22) //Comparamos para descartar que ningún dígito se repite (mitad de dígitos)
            {
                if (numDig12 != numDig22 && numDig12 != numDig22) //Comparamos para descartar que ningún dígito se repite (la otra mitad)
                {
                    Console.WriteLine("Ninguno de los números coinciden. ");
                }
            }
            Console.ReadLine();


            /**
             * Vamos a escribir varios programas que saludan al usuario al iniciar. El usuario tiene asociadas 3 variables,
             * una que indica si ha pagado la entrada, una que indica si es cliente VIP y la otro el saldo que tiene 
             * (positivo para saldo de más, negativo para deuda). Haz un programa por cada punto:
             * Comprobar si se ha pagado la entrada. Si se ha pagado, mostramos mensaje "Bienvenido",si no mostrar mensaje "Tienes que pagar la entrada".

             * A todos se les dice "Bienvenido", pero si es cliente VIP después de "Bienvenido" también se le dice "Que pase un buen día" 

             * Si no tiene deudas, le damos la bienvenida. En caso contrario no hacemos nada.

             * Solo damos la bienvenida en el caso de cliente vip y el saldo sea mayor que 0
             **/

            int saldo;
            Console.WriteLine("¿Eres VIP?");
            string respuesta = Console.ReadLine();

            if (respuesta == "si")
            {
                Console.WriteLine("Bienvenido, que tengas un buen día. ");
            }
            else if (respuesta == "no")
            {
                Console.WriteLine("Bienvenido. ");
            }
            Console.ReadLine();

            Console.WriteLine("¿Has pagado la entrada? ");
            string respuesta1 = Console.ReadLine();
            if (respuesta1 == "si")
            {
                Console.WriteLine("Bienvenido. ");
            }
            else if (respuesta1 == "no")
            {
                Console.WriteLine("Tienes que pagar la entrada. ");
            }
            Console.ReadLine();


            Console.WriteLine("¿Qué saldo tienes en cuenta? ");
            saldo = Int32.Parse(Console.ReadLine());

            if (saldo >= 0)
            {
                Console.WriteLine("Bienvenido. ");
            }
            Console.ReadLine();

            Console.WriteLine("¿Eres VIP?");
            string respuesta2 = Console.ReadLine();
            Console.WriteLine("¿Cuánto saldo tienes en cuenta?");
            saldo = Int32.Parse(Console.ReadLine());
            if (respuesta2 == "si" && saldo >= 0)
            {
                Console.WriteLine("Bienvenido. ");
            }
            Console.ReadLine();
            Console.WriteLine();



            Resultado de carrera.Hacer varios programas en los que se le pregunta al usuario el puesto en el que acabó.Después:

            //Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.

            //Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2,
            //mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante es participar.

            //Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro",
            //si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce"
            //y al resto "Lo importante es participar.

            //Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje "Se acabó la carrera".
            //Hazlo usando un if/else y usando switch

            int puestoCarrera;
            Console.WriteLine("¿En qué puesto has acabado? ");
            puestoCarrera = Int32.Parse(Console.ReadLine());
            if (puestoCarrera == 1)
            {
                Console.WriteLine("Ganaste. ");
            }
            else
            {
                Console.WriteLine("Lo importante es participar. ");
            }
            Console.ReadLine();
            Console.WriteLine();

            int puestoCarrera1;
            Console.WriteLine("¿En qué puesto has quedado?");
            puestoCarrera1 = Int32.Parse(Console.ReadLine());

            if (puestoCarrera1 == 1)
            {
                Console.WriteLine("Medalla de Oro. ");
            }
            if (puestoCarrera1 == 2)
            {
                Console.WriteLine("Medalla de Plata. ");
            }
            if (puestoCarrera1 == 3)
            {
                Console.WriteLine("Medalla de Bronce. ");
            }
            else
            {
                Console.WriteLine("Lo importante es participar. ");
            }
            Console.ReadLine();
            Console.WriteLine();

            int puestoCarrera3;
            Console.WriteLine("¿En qué puesto has quedado?");
            puestoCarrera3 = Int32.Parse(Console.ReadLine());

            switch (puestoCarrera3)
            {
                case 1:
                    Console.WriteLine("Sube al pódium. ");
                    break;

                case 2:
                    Console.WriteLine("Sube al pódium. ");
                    break;

                case 3:
                    Console.WriteLine("Sube al pódium. ");
                    break;

                default:
                    Console.WriteLine("Lo importante es participar. ");
                    break;
            }
            Console.ReadLine();
            Console.WriteLine();


            Si la edad es igual o inferior a 8 mostramos mensaje "Pasa al tobogán", 
            si no mostramos "Eres demasiado mayor para usar el tobogán"

            int edadTobo;
            Console.WriteLine("¿Cuántos años tienes? ");
            edadTobo = Int32.Parse(Console.ReadLine());

            if (edadTobo <= 8)
            {
                Console.WriteLine("Puedes subir al tobogán. ");
            }
            else
            {
                Console.WriteLine("Demasiado viejo. ");
            }
            Console.ReadLine();
            Console.WriteLine();

            Comprobar un string que tenga el valor del día de la semana(lunes, martes, ...). 
             Mostrar en pantalla el día que dice que es si es entre lunes y viernes(Por ejemplo "Hoy es lunes")
             y si es fin de semana mostrar "Es fin de semana" Con switch y con if else.

            Console.WriteLine("¿Qué día de la semana es?");
            string respuesta = Console.ReadLine();

            if (respuesta == "lunes" || respuesta == "martes" || respuesta == "miércoles" || respuesta == "jueves" || respuesta == "viernes")
            {
                Console.WriteLine("Es día laboral. ");
            }
            else if (respuesta == "sábado" || respuesta == "domingo")
            {
                Console.WriteLine("Es fin de semana. ");
            }
            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("¿Qué día de la semana es?");
            string respuesta1 = Console.ReadLine();

            switch (respuesta1)
            {
                case "lunes":
                    Console.WriteLine("Es lunes. ");
                    break;

                case "martes":
                    Console.WriteLine("Es martes. ");
                    break;

                case "miércoles":
                    Console.WriteLine("Es miércoles. ");
                    break;

                case "jueves":
                    Console.WriteLine("Es jueves. ");
                    break;

                case "viernes":
                    Console.WriteLine("Es viernes. ");
                    break;

                case "sábado":
                    Console.WriteLine("Es fin de semana. ");
                    break;

                case "domingo":
                    Console.WriteLine("Es fin de semana. ");
                    break;

                default:
                    Console.WriteLine("Eso no es un día de la semana. ");
                    break;
            }
            Console.ReadLine();
            Console.WriteLine();


            A partir de un valor de número entero, mostrar el mensaje "El valor absoluto de -7 es 7".
             Si es menor que cero mostrar el valor en positivo, si es positivo o cero mostrar ese mismo valor.

            int valorAbsol;
            Console.WriteLine("Dame un número que sacamos su valor absoluto.");
            valorAbsol = Int32.Parse(Console.ReadLine());

            if (valorAbsol < 0)
            {
                Console.WriteLine("El valor absoluto de " + valorAbsol + " es " + (+valorAbsol));
            }
            else
            {
                Console.WriteLine("EL valor absoluto de " + valorAbsol + " es " + valorAbsol);
            }
            Console.ReadLine();
            Console.WriteLine();





        }
    } 
}
        
    





































