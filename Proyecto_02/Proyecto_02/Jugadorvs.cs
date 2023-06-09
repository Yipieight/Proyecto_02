﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Proyecto_02
{
    class Jugadorvs
    {
        public static int[] turnosporjugador = new int[3] { 0, 0, 0 };
        public static string[] nombreactual = new string[3] { "", "", "" };
        public static string piezactual = "";
        public static string jugador1 = "", jugador2 = "";
        public static int columna = 0;
        public static void colocarpieza()
        {

            columna = Controles.controltabla();
        }

        
        
        public static void jugador1o2()
        {
            Random r = new Random();

            if (piezactual != jugador1 || piezactual == "")
            {
                piezactual = jugador1;
                do
                {
                    colocarpieza();
                }
                while (Tabla.tablacolocar(columna));
                turnosporjugador[0] += 1;
            }
            else if (nombreactual[2] != "CPU1")
            {
                piezactual = jugador2;
                do
                {
                    colocarpieza();
                }
                while (Tabla.tablacolocar(columna));
                turnosporjugador[1] += 1;
            }
            else
            {
                piezactual = jugador2;
                do
                {
                    columna = r.Next(0,7);
                    Thread.Sleep(600);
                }
                while (Tabla.tablacolocar(columna));
                turnosporjugador[2] += 1;
            }
        }
        public static void nombrejugadores()
        {
            Console.Clear();
            if (Controles.subindice == 1)
            {
                visualizacion.menunombrescodigoj1();
                visualizacion.menunombrescodigoj2();
            }
            else if (Controles.subindice == 2)
            {
                visualizacion.menunombrescodigoj1();
                nombreactual[2] = "CPU1";
            }

        }
        public static void nombrej1()
        {
            Console.WriteLine("Ingrese el nombre del primer jugador (J1)");
            nombreactual[0] = Console.ReadLine();
        }
        
    }
}
