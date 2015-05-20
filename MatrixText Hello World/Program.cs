using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_Hello_World
{
    //*************************************************************************************//
    //                                                                                     //
    //  Author:                                                                            //
    //     Name:                  Jakub                                                    //
    //     Surname:          Brzegowski                                                    //
    //     Nick:            brzegator27                                                    //
    //                                                                                     //
    //  Program:                                                                           //
    //     Name: MatrixText Hello World                                                    //
    //     version:                 1.0                                                    //
    //                                                                                     //
    //*************************************************************************************//


    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            try
            {
                Console.SetWindowSize(101, 41);
                Console.Title = "MatrixText Effect - by brzegator27";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            MatrixTextEffect myEffect = new MatrixTextEffect(101, 41, "Hello World!", true, 25);
            myEffect.StartMatrix();

            Console.ReadKey();
        }
    }
}
