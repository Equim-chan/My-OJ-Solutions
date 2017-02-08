// 0512 Caesar Cipher (シーザー暗号)
// http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0512
// by Equim on 17-02-08

'use strict';

// PROCESS
function caesar(cipherText) {
    var plainText = '';

    // buf is ASCII code
    var buf;

    for (var i = 0; i < cipherText.length; i++)
    {
        buf = cipherText.charCodeAt(i) - 3;
        if (buf < 65) {
            buf += 26;
        }
        plainText += String.fromCharCode(buf);
    }
    
    return plainText;
}

// IO (RAW)
require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
}).on('line', function (line) {
    console.log(caesar(line.trim()));
});
