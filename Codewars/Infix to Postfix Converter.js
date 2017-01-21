// Infix to Postfix Converter
// https://www.codewars.com/kata/infix-to-postfix-converter
// by Equim on 17-01-21

//Array.prototype.peek = () => this[this.length - 1];
function toPostfix(infix) {
    const order = {
        '+': 0,
        '-': 0,
        '*': 1,
        '/': 1,
        '^': 2
    };
    let ret = '';
    let stack = [];
    const peek = () => stack[stack.length - 1];
    // 很丑，很恶心
    for (let i = 0; i < infix.length; i++) {
        let item = infix.charAt(i);
        if (!isNaN(item)) {
            ret += item;
        } else if (item === ')') {
            while (peek() !== '(') {
                ret += stack.pop();
            }
            stack.pop();
        } else {
            if (stack.length !== 0 && item !== '(' && peek() !== '(') {
                while (order[item] - (item === '^' ? 1 : 0) <= order[peek()]) {
                    ret += stack.pop();
                }
            }
            stack.push(item);
        }
    }
    while (stack.length) {
        ret += stack.pop();
    }
    return ret;
}