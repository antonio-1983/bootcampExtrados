
using System;

    // Función para verificar si una reina puede ser colocada en la posición (fila, columna)
     bool SePuedeInsertar(int[][] tablero, int fila, int columna)
    {
        // Verificar la fila en la izquierda
        for (int i = 0; i < columna; i++)
        {
            if (tablero[fila][i] == 1)
            {
           // Console.WriteLine("false en fila a la izquierda " + i + " fila ," + columna + " columna");
            return false;
            }
            
        }

    // Verificar la columna
    for (int i = 0; i < fila; i++)
    {
        if (tablero[i][columna] == 1)
        {
            //Console.WriteLine("false en columna de arriba/abajo " + i + " fila ," + columna + " columna");
            return false;
        }

    }


    // Verificar la diagonal superior izquierda
    for (int i = fila, j = columna; i >= 0 && j >= 0; i--, j--)
        {
            if (tablero[i][j] == 1)
            {
           // Console.WriteLine("false en diagonal superior izquierda " + i + " fila ," + columna + " columna");
            return false;
            }
                
                
        }

        // Verificar la diagonal inferior izquierda
        for (int i = fila, j = columna; i < 8 && j >= 0; i++, j--)
        {
            if (tablero[i][j] == 1)
            {
           // Console.WriteLine("false en diagonal inferior izquierda" + i + " fila ," + columna + " columna");
            return false;
            }
                
        }

        //agrego mas condiciones **************************************

        // Verificar la diagonal superior derecha
        for (int i = fila, j = columna; i >= 0 && j <= 0; i--, j++)
        {
            if (tablero[i][j] == 1)
            {
            //Console.WriteLine("false en diagonal superior derecha " + i + " fila ," + columna + " columna");
            return false;
            }
                
        }
        // Verificar la diagonal inferior derecha
        for (int i = fila, j = columna; i < 8 && j <= 0; i++, j++)
        {
            if (tablero[i][j] == 1)
            {
            //Console.WriteLine("false en diagonal inferior derecha " + i + " fila ," + columna + " columna");
            return false;
            }
                
        }

        return true;
    }

    // Función recursiva para resolver el problema de las 8 reinas
      bool  InsertarReina(int[][] tablero, int columna)
    {
        if (columna >= 8)
            return true;//aca estan todas las reinas puestas y listas para imprimir el tablero

        for (int i = 0; i < 8; i++)
        {
            if (SePuedeInsertar(tablero, i, columna))
            {
                tablero[i][columna] = 1;
               // Console.WriteLine("el primero" + i+" fila ," + columna+" columna");

                if (InsertarReina(tablero, columna + 1))
                {
               // Console.WriteLine(i + " fila ," + (columna + 1) + " columna");
                return true;
                }

                tablero[i][columna] = 0; // deshace el movimiento
                //Console.WriteLine("deshace el movimiento -> "+i + " fila ," + columna + " columna");
            }
        }

        return false; // Si no se pueden colocar todas las reinas
    }

    
        int[][] tablero = new int[8][];
        for (int i = 0; i < 8; i++)
        {
            tablero[i] = new int[8];
        }


         if(InsertarReina(tablero, 0))
        {
            Console.WriteLine("Solución 8 reinas");
            Console.WriteLine("0 - casillero vacio ");
            Console.WriteLine("1 - Reina insertada");
            Console.WriteLine("--------------------");
    for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(tablero[i][j] + "");
                }
                Console.WriteLine();
            }
        }

