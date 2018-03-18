using System;
using System.Text;
using System.Collections.Generic;

namespace Task4
{
    public class ConsoleGame : IGameField
    {
        static private int _width;
        static private int _height;

        public int Width
        {
            get
            {
                return _width;
            }
            private set
            {
                if(value > 0)
                {
                    _width = value;
                }
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            private set
            {
                if (value > 0)
                {
                    _height = value;
                }
            }
        }

        string[,] field;

        public ConsoleGame(int width, int height)
        {
            Width = width;
            Height = height;
            field = new string[_width, _height];
        }

        public void DisplayStatus(string name, int x, int y)
        {
            System.Console.WriteLine($"{name} ({x},{y})");
        }

        public void Draw(string name, int x, int y)
        {
            // пока не появится рисовалка символов
            DisplayStatus(name, x, y);
            //Display();
        }

        public void Place(List<GameObject> gameObjects)
        {

            var symbol = String.Empty;

            foreach (GameObject element in gameObjects)
            {

                switch (element.Type)
                {
                    case ObjectType.Player:
                        symbol = "P";
                        break;
                    case ObjectType.Enemy:
                        symbol = "M";
                        break;
                }

                field[element.X, element.Y] = symbol;
            }
        }

        public void Place(GameObject gameObject)
        {

            var symbol = String.Empty;

                switch (gameObject.Type)
                {
                    case ObjectType.Player:
                        symbol = "P";
                        break;
                    case ObjectType.Enemy:
                        symbol = "M";
                        break;
                }

                field[gameObject.X, gameObject.Y] = symbol;
        }

        public void Clear()
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    field[i, j] = "_";
                }
            }
        }

        public void Display()
        {
            var sb = new StringBuilder();
            for (int j = 0; j < field.GetLength(1); j++)
            {
                sb.Append("|");
                for (int i = 0; i < field.GetLength(0); i++)
                {
                    sb.Append(field[i, j]);
                }
                sb.Append("|\n");
            }
            Console.WriteLine(sb);
        }
    }
}
