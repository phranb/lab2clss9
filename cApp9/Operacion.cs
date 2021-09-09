using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace cApp9
{
    public static class Operacion
    {
        private static char _selection;
        private static double _userInputOne;
        private static double _userInputTwo;
        
        public static void Menu()
        {
            Console.WriteLine("Seleccione segun corresponda: ");
            Console.WriteLine("'s' Para sumar, 'r' Para restar");
            Selection = ReadOperation();
            Selection = Char.ToUpper(Selection);
            switch (Selection)
            {
                case 'S':
                    Console.WriteLine("Suma.");
                    Console.WriteLine("Ingrese primer numero a sumar");
                    UserInputOne = HandleInput();
                    Console.WriteLine("Ingrese segundo numero a sumar");
                    UserInputTwo = HandleInput();
                    Console.WriteLine("Suma igual a: " + Sumar(UserInputOne, UserInputTwo));
                    break;
                case 'R':
                    Console.WriteLine("Resta.");
                    Console.WriteLine("Ingrese primer numero a restar");
                    UserInputOne = HandleInput();
                    Console.WriteLine("Ingrese segundo numero a restar");
                    UserInputTwo = HandleInput();
                    Console.WriteLine("Resta igual a: " + Restar(UserInputOne, UserInputTwo));
                    break;
                    
            }
           
        }
        
        private static double Sumar(double first, double second)
        {
            return first + second;
        }

        private static double Restar(double first, double second)
        {
            return first - second;
        }

        private static char ReadOperation()
        {
            char aux = 'a';
            try
            {
                aux = Convert.ToChar(Console.ReadLine()[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return aux;
        }

        private static double HandleInput()
        {
            double aux = -1;
            try
            {
                aux = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return aux;
        }
        
        private static char Selection
        {
            get
            {
                return _selection;
            }
            set
            {
                _selection = value;
            }
        }

        private static double UserInputOne
        {
            get
            {
                return _userInputOne;
            }
            set
            {
                _userInputOne = value;
            }
        }

        private static double UserInputTwo
        {
            get
            {
                return _userInputTwo;
            }
            set
            {
                _userInputTwo = value;
            }
        }
        
        

    
    }
}