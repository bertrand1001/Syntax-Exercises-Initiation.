using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Sintaxis_BIEN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribe un programa que muestre en pantalla “Hola” seguido de tu nombre  
            //Write a program that displays "Hello" followed by your name

            Console.WriteLine("Hola Bertrand!");



            //Escribe un programa que muestre la suma de dos números
            // Write a program that shows the sum of two numbers
            Console.WriteLine("El resultado de la suma es " + (72 + 5));


            //Escribe un programa que calcule la división de dos números y lo muestre en pantalla
            //Write a program that calculates the division of two numbers and show it on the screen

            Console.WriteLine("El resultado de la mutiplicacion es " + (88.0 / 3));

            //Escribe un programa que muestre el resultado de las siguientes operaciones:
            // Write a program that shows the result of the following operations:   

            Console.WriteLine(-5 + 8 * 6);
            Console.WriteLine((55 + 9) % 9);
            Console.WriteLine(20 + -3 * 5 / 8);
            Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);


            // Escribe un programa que pida dos números al usuario y muestre el resultado de multiplicar los dos

            int multiplicacion;
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un número entero:");
         
           Console.WriteLine("Introduce otro número entero:");
            
            multiplicacion = num1 * num2;
            Console.WriteLine("La multiplicación de los números es " + multiplicacion);


            // Escribe un programa que pida dos números al usuario y muestre el resultado de sumarlos, multiplicarlos, restarlos, dividirlos y el resto de la división


            int multiplicacion1;
            int suma1;
            int division1;
            int resto1;
            Console.WriteLine("Introduce un número entero:");
            int num11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número entero:");
            int num22 = Convert.ToInt32(Console.ReadLine());

            multiplicacion1 = num11 * num22;
            Console.WriteLine("La multiplicación de los números es " + multiplicacion);

            suma1 = num11 + num22;
            Console.WriteLine("La suma de los números es " + suma1);


            division1 = num11 / num22;
            Console.WriteLine("La division de los números es " + division1);


            resto1 = num11 % num22;
            Console.WriteLine("El resto  de los números es " + resto1);





            // Escribe un programa que pida un número al usuario y muestre la tabla de multiplicar hasta 10 de ese número. Por ejemplo si metemos un 8 que muestre:
            //int num5;
            //num5= Int32.Parse(Console.ReadLine());
            //Console.WriteLine(num5 + " X 1 = " + (num5 * 1) +
            //                  "\n" + num5 + " X 2 = " + (num5 * 2) +
            //                  "\n" + num5 + " X 3 = " + (num5 * 3) +
            //                  "\n" + num5 + " X 4 = " + (num5 * 4) +
            //                  "\n" + num5 + " X 5 = " + (num5 * 5) +
            //                  "\n" + num5 + " X 6 = " + (num5 * 6) +
            //                  "\n" + num5 + " X 7 = " + (num5 * 7) +
            //                  "\n" + num5 + " X 8 = " + (num5 * 8) +
            //                  "\n" + num5 + " X 9 = " + (num5 * 9) +
            //                  "\n" + num5 + " X 10 = " + (num5 * 10));

            //Escribe un programa que calcule el resultado de la siguiente operación:
            Console.WriteLine((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));

            //Escribe un programa que calcule el resultado de la siguiente operación:
            Console.WriteLine(4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11)));

            //Escribe un programa que pida al usuario el radio de un círculo y que calcule y muestre el área y el perímetro(el área de un círculo es PI por radio cuadrado y el perímetro es 2 por radio por PI). PI es = 3.141593

            Console.WriteLine("Introduce el radio de un círculo");
            const double PI = 3.141593;
            int radio = Int32.Parse(Console.ReadLine());
            double area, perimetro;
            area = Math.Pow(radio, 2) * PI; 
            perimetro = 2 * PI * radio;
            Console.WriteLine("El área del círculo es " + area + "\n El perímetro del círculo es " + perimetro);


             
            // Escribe un programa que pida al usuario la anchura y altura de un rectángulo y que calcule y muestre su área y su perímetro(el área es la altura por la anchura y el perímetro es 2 por la suma de la altura y la anchura
 
             Console.WriteLine("Anchura del rectangulo:");
            int anchura;
            anchura = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Altura del rectangulo:");
            int altura;
            altura = Int32.Parse(Console.ReadLine());
            int areaRectangulo, perimetroRectangulo;
            areaRectangulo = altura * anchura;
            perimetroRectangulo = 2 * (altura + anchura);
            Console.WriteLine("El área del rectangulo es " + areaRectangulo);
            Console.WriteLine("El perímetro del rectangulo es " + perimetroRectangulo);

            //Escribe un programa que pida dos variables, y después intercambie sus valores(si por ejemplo ponemos 8 en la variable a y 5 en la variable b, que al final del programa la variable a tenga el valor 5 y la variable b el valor 8).


            Console.WriteLine("Introduce variable numérica 'a':");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce variable numérica 'b':");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("'a' es " + a + " y " + "'b' es " + b);
            int cam; // Introducimos una variable que nos cambiara el orden de la impresion en pantalla
            cam = a;
            a = b;
            b = cam;
            Console.WriteLine("Después de intercambiar valores...");
            Console.WriteLine("'a' es " + a + " y " + "'b' es " + b);

            //Escribe un programa que pida un número de 3 dígitos y que muestre en pantalla el resultado de sumarlos.
            Console.WriteLine("Introduce un número de tres dígitos:");
            int num9 = Int32.Parse(Console.ReadLine());
            int pri, sec, ter, sumTres;
            ter = num9 % 10;
            sec = ((num9 % 100) - ter) / 10;
            pri = ((num9 % 1000) - ter - (sec * 10)) / 100;
            sumTres = pri + sec + ter;
            Console.WriteLine(pri + "\n" + sec + "\n" + ter + "\n" + "La suma de los tres dígitos es " + sumTres);

            // Escribe un programa que pida al usuario un dígito(n) y calcule y muestre el valor de n+nn + nnn.Por ejemplo si el usuario introduce 5 el programa calcularía 5 + 55 + 555
            int num10;
            num10= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un número de dígito:");
            
            Console.WriteLine("El primer digito es: " + num10 + "\n + El segundo Digito  es: " + num10 + num10 + "\n +El Tercer Digito es  es " + num10 + num10 + num10);

            //Escribe un programa que pida un número de 3 dígitos y que muestre en pantalla el resultado de sumarlos.

            int numero;
                numero=int.Parse(Console.ReadLine());
            int primerdigito, segundodigito, tercerdigito, sumas;
            Console.WriteLine("Introduce un número de tres dígitos:");
          
            tercerdigito = num9 % 10;
            segundodigito = ((num9 % 100) - tercerdigito) / 10;
            primerdigito = ((num9 % 1000) - tercerdigito - (sec * 10)) / 100;
            sumas = primerdigito + segundodigito + tercerdigito;
            Console.WriteLine(primerdigito + "\n" + segundodigito + "\n" + tercerdigito + "\n" + "La suma de los tres dígitos es " + sumas);

            // Escribe un programa que pida al usuario un número y convierta el string a un int y lo muestre en pantalla.
            Console.WriteLine("Introduce un número de  número:");
            int num111 ;
                num111= Int32.Parse(Console.ReadLine());
            Console.WriteLine(num11);

            //Escribe un programa que calcule el resto de dividir dos números sin utilizar el operador de división de resto(%)
            Console.WriteLine("Introduce el divisor:");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el dividendo:");
            int y = Int32.Parse(Console.ReadLine());
            int resto2;
            resto2 = x - (y * (x / y));
            Console.WriteLine("El resto es " + resto2 + "\n" + (x % y));



            //Escribe un programa que le pida al usuario un número de pulgadas y lo convierta a metros(una pulgada son 0.0254 metros)
            Console.WriteLine("Introduce el número de pulgadas:");
            const double factorConv = 0.0254;
            double pulgadas = Double.Parse(Console.ReadLine()), metros;
            metros = pulgadas * factorConv;
            Console.WriteLine(pulgadas + " pulgadas son " + metros + " metros");


            //Escribe un programa que pida un número de minutos y muestre cuantos años y días son
            Console.WriteLine("Introduce el número de minutos:");
            int mins = Int32.Parse(Console.ReadLine()), años, dias;
            const int convMins = 60, convDays = 24, convYears = 365;
            años = mins / (convMins * convDays * convYears);
            dias = (mins / (convMins * convDays)) % 365;
            Console.WriteLine(mins + " minutos son " + años + " años y " + dias + " días");

            //Escribe un programa que pida una distancia(en metros), y el tiempo tardado(como tres números: horas, minutos y segundos) y que muestre la velocidad en metros por segundo y kilómetros por hora.

            Console.WriteLine("Introduce una distancia en metros:");
            Double metros1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tiempo transcurrido para hacer esa distancia (h,min,s):");
            Double hora = Double.Parse(Console.ReadLine());
            Double minuto = Double.Parse(Console.ReadLine());
            Double segundo = Double.Parse(Console.ReadLine());
            Double tiempo = (hora * 3600) + (minuto * 60) + segundo;
            Double mpors = (metros1 / tiempo);
            Double kmporh = mpors * 3.6;
            Console.WriteLine("La velocidad a la qu has ido es:\n" + mpors + " m/s o" + "\n" + kmporh + " km/h");


            // Escribe un programa que genere un número aleatorio entre el 1 y el 100(pista: hay que utilizar una función).

            Random r = new Random();
            int rInt = r.Next(1, 100);
            Console.Write(rInt);

            //Escribe un programa que pida dos números y que muestre la suma, la resta, la multiplicación, la media, el máximo y el mínimo.

            Console.WriteLine("Introduce dos números:");
            double num121 = Double.Parse(Console.ReadLine());
            double num12 = Double.Parse(Console.ReadLine());
            double sum2, resta2, multiplicacion3, media2, max, min;
            sum2 = num121 + num12;
            resta2 = num11 - num12;
            multiplicacion3 = num121 * num12;
            media2 = (num11 + num12) / 2;

            Console.WriteLine("La suma entre números es " + sum2 +
                              "\nLa resta entre los números " + num121 + " y " + num12 + " es " + resta2 +
                              "\nLa multiplicación de los números es " + multiplicacion3 +
                              "\nLa media de los números es " + media2 );
                             



            Console.ReadLine();

        }
    }
}   

    

