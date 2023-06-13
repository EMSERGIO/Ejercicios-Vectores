using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicios 7

            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo 
            // y su posición dentro del vector.

            // int n, pos, maximo;
            // int[] numeros = new int[10];

            // for (int x = 0; x < 10; x++)
            // {
                // Console.WriteLine("Ingrese un numero: ");
                // n = int.Parse(Console.ReadLine());
                // numeros[x] = n;
            // }
            // maximo = numeros[0];
            // pos = 1;
            // for (int x = 0; x < 10; x++)
            // {
                // if (numeros[x] > maximo)
                // {
                    // maximo = numeros[x];
                    // pos = x + 1;
                // }

            // }
            
            // Console.WriteLine("La posicion es: " + pos + " con un maximo de: " + maximo);

            //..............................................................................................

            // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los 
            // valores que son mayores al promedio.

            // int n, promedio = 0, acu;
            // int[] numeros = new int[10];

            // for (int x = 0; x < 10; x++)
            // {
                // Console.WriteLine("Ingrese un numero:");
                // n = int.Parse(Console.ReadLine());
                // numeros[x] = n;
            // }

            // acu = 0;
            // for (int x = 0; x < 10; x++)
            // {
                // acu += numeros[x];
            // }

            // promedio = acu /10;
            // for (int x = 0; x < 10; x++)
            // {
                // if (numeros[x] > promedio)
                // {
                    // Console.WriteLine("Los numeros mayor al promerdio son: " + numeros[x]);
                // }

            // }

            // Console.WriteLine("El promedio general es: " + promedio);


            //..............................................................................................

            // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
            //  El programa deberá generar una cadena donde todas las ocurrencias del primer carácter 
            //  dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"ç


            //manera larga de resolver el problema:
            

            // char[] frase = new char[30];
            // char letraActual;
            // char letraNueva;
            // char letra;
            // int indice = 0;

            // Console.WriteLine("Ingrese una letra para la frase");
            // letra = char.Parse(Console.ReadLine());
            // while (letra !='0' &&  indice < 30)
            // {
                // frase[indice] = letra;
                // Console.WriteLine("Ingrese otra una letra para la frese");
                // letra = char.Parse(Console.ReadLine());
                // indice++;
            // }
            // frase[indice] = '\0';
            // //Console.Write("La frese completa es:");
            // indice = 0;
            // while (frase[indice] != '\0')
            // {
                // Console.WriteLine(frase[indice]);
                // indice++;
            // }

            // Console.WriteLine("Ingrese letra a reemplazar:");
            // letraActual = char.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la letra nueva:");
            // letraNueva = char.Parse(Console.ReadLine());
            
            // indice = 0;
            // while (frase[indice] != '\0')
            // {
                // if(frase[indice] == letraActual){

                    // frase[indice] = letraNueva;
                // }
                // indice++;

            // }
            // Console.WriteLine("La frase nueva es: ");
            // indice = 0;
            // while(frase[indice] == '\0')
            // {
                // Console.Write(frase[indice]);
                // indice++;
            // }


            // string frase;
            // char letraActual;
            // char letraNueva;
            // Console.WriteLine("Ingrese letra a reemplazar:");
            // frase = Console.ReadLine();
            // Console.WriteLine("Ingrese letra a reemplazar:");
            // letraActual = char.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la letra nueva:");
            // letraNueva = char.Parse(Console.ReadLine());

            // frase = frase.Replace(letraActual, letraNueva);
            // Console.WriteLine("La frase nueva es: ");
            // Console.WriteLine(frase);


            //..............................................................................................


            // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada 
            // genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 
            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.

            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.
            

            // int numArticulo;
            // int cantidadVendida;
            // int[] masVendido = new int[3];

            // for (int x = 0; x < 3; x++)
            // {
                // masVendido[x] = 0;
            // }

            // Console.WriteLine("Ingrese numero de Articulo: ");
            // numArticulo = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese cantidad vendida: ");
            // cantidadVendida = int.Parse(Console.ReadLine());

            // while(numArticulo != 0)
            // {
                // masVendido[numArticulo - 1] += cantidadVendida;



                // Console.WriteLine("Ingrese numero de Articulo: ");
                // numArticulo = int.Parse(Console.ReadLine());
                // Console.WriteLine("Ingrese cantidad vendida: ");
                // cantidadVendida = int.Parse(Console.ReadLine());
            // }

            // //Punto A
            // int maxCantidad = masVendido[0];
            // int numMaximo = 1;
            // for (int x = 0; x < 3; x++)
            // {
                // if (masVendido[x] > maxCantidad)
                // {
                    // maxCantidad = masVendido[x];
                    // numArticulo = x + 1;
                // }
            // }
            // Console.WriteLine("El producto mas vendido es el: " + numArticulo + " con la cantidad de: " + maxCantidad);

            // //Punto B
            // for (int x = 0; x < 3; x++)
            // {
                // if (masVendido[0] == 0)
                // {
                    // Console.WriteLine("El producto " + (x + 1) + " no tuvo ventas");
                // }
            // }

            // //Punto C
            // Console.WriteLine("La cantidad vendida del articulo 10 es: " + masVendido[1]);









            
            










            



        

        }
    }
}

// 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada 
// genera un registro con los siguientes datos:
// - Número de Artículo (1 a 15)
// - Cantidad Vendida 
// Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
// Se pide determinar e informar:
// a) El número de artículo que más se vendió en total.
// b) Los números de artículos que no registraron ventas.
// c) Cuantas unidades se vendieron del número de artículo 10.