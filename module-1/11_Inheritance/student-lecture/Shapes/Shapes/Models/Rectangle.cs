﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
   public  class Rectangle :Shape2D
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int Area
        {
            get
            {
                return Width * Height;
            }
        }
        public override int Perimeter
        {
            get
            {
                return (2 * Width) + (2 * Height);
            }
        }

        //constructor
        public Rectangle (int width, int height, ConsoleColor color, bool isFilled)
        {
            Width = width;
            Height = height;
            Color = color;
            IsFilled = isFilled;
        }
        public override void Draw()
        {
            SetConsoleColor();

            #region Do the math to calculate which symbols to draw
            double thickness = .8;
            char symbol = '*';
            char fillSymbol = '*';

            // Do the math to calculate which symbols to draw
            for (int y = 0; y < this.Height; y++)
            {
                for (double x = 0; x < this.Width; x += .4)
                {
                    if (y < thickness || y >= (this.Height - 1 - thickness) ||
                        x < thickness || x >= (this.Width - thickness))
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        if (this.IsFilled &&
                            y >= thickness && y < (this.Height - thickness) &&
                        x >= thickness && x < (this.Width - thickness)
                            )
                        {
                            Console.Write(fillSymbol);

                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
            #endregion

            ResetConsoleColor();

        }
        public override string ToString()
        {
            return $"A {Color} Rectangle {Width} by {Height} {(IsFilled} ? "" :" not")}";//ternary
        }
}
