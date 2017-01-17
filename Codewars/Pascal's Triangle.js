// Pascal's Triangle
// https://www.codewars.com/kata/pascals-triangle
// by Equim on 17-01-17

function Triangle(n) {
    if (n === 1){
        return [1];
    }
    var ret = [];
    var prev = [0].concat(Triangle(n - 1).concat([0]));
    for (var i = 0; i < n; i++) {
        ret.push(prev.pop() + prev[prev.length - 1]);
    }
    return ret;
}
function pascalsTriangle(n) {
    var ret = [];
    for (var i = 1; i <= n; i++) {
        ret = ret.concat(Triangle(i));
    }
    return ret;
}