// Reverse polish notation calculator
// https://www.codewars.com/kata/reverse-polish-notation-calculator/
// by Equim on 16-12-16

function calc(input)
{
    if (input == "") return 0;

    var Expr = input.split(' ');
    var num = [];

    for (var item in Expr)
    {
        switch (Expr[item])
        {
            case "+": num.push(parseFloat(num.pop() + num.pop())); break;
            case "-": num.push(parseFloat(-num.pop() + num.pop())); break;
            case "*": num.push(parseFloat(num.pop() * num.pop())); break;
            case "/": num.push(parseFloat(1 / num.pop() * num.pop())); break;
            default: num.push(parseFloat(Expr[item])); break;
        }
    }
    return num.pop();
}