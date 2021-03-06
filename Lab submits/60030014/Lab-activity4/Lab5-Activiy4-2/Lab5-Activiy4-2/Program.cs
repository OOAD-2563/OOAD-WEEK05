﻿using System;

namespace Lab5_Activiy4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Rectangle : Square
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a rectangle.");
        }
    }
    public static int Main()
    {

        // 1. สร้างอาร์เรย์ของออปเจกต์ของ base class มีพื้นที่เก็บ 5 ออปเจ็กต์ 
        DrawingObject[] dObj = new DrawingObject[5];


        // 1. สร้างออปเจกต์จาก derived class แต่ละตัวแล้วเก็บ reference ในอาร์เรย์ 
        dObj[0] = new Line();
        dObj[1] = new Circle();
        dObj[2] = new Square();
        dObj[3] = new Rectangle();
        dObj[4] = new DrawingObject();

        // วนลูปเพื่อเรียกเมธอดในแต่ละออปเจ็กต์
        foreach (DrawingObject drawObj in dObj)
        {
            drawObj.Draw();
        }

        return 0;
    }
}
