// Reverse polish notation calculator
// https://www.codewars.com/kata/reverse-polish-notation-calculator/
// by Equim on 16-12-16

using System;
using System.Collections.Generic;
using System.Linq;

public class Calc
{
    public double evaluate(string input)
    {
        if (input == "") return 0D;

        var Expr = input.Split(' ');
        Stack<double> num = new Stack<double>();

        foreach (var item in Expr)
        {
            switch (item)
            {
                case "+": num.Push(num.Pop() + num.Pop()); break;
                case "-": num.Push(-num.Pop() + num.Pop()); break;
                case "*": num.Push(num.Pop() * num.Pop()); break;
                case "/": num.Push(1D / num.Pop() * num.Pop()); break;
                default: num.Push(double.Parse(item)); break;
            }
        }
        return num.Pop();
    }
}