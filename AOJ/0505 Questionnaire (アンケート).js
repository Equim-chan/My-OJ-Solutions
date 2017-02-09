// 0505 Questionnaire (アンケート)
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0505
// by Equim on 17-02-08

'use strict';

var raw = require('fs').readFileSync('/dev/stdin', 'utf8').trim().split('\n');

while (true) {
    var size = raw.shift().split(' ').map(Number);
    if (size[0] === 0) {
        break;
    }

    var count = {};
    for (var i = 0; i < size[0]; i++) {
        var line = raw.shift().split(' ').map(Number);
        for (var j = 0; j < size[1]; j++) {
            count[j + 1] = ((j + 1) in count ? count[j + 1] : 0) + line[j];
        }
    }

    // Support Lambda pls QAQ
    console.log(Object.keys(count).sort(function(a, b) { return count[a] === count[b] ? a - b : count[b] - count[a]; }).join(' '));
}
