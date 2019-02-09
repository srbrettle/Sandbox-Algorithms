'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

function getLetter(s) {
    let letter;
    let firstCharacter = s[0];
    switch (true) {
        case 'aeiou'.includes(firstCharacter):
            letter = 'A';
            break;
        case 'bcdfg'.includes(firstCharacter):
            letter = 'B';
            break;
        case 'hjklm'.includes(firstCharacter):
            letter = 'C';
            break;
        case 'npqrstvwxyz'.includes(firstCharacter):
            letter = 'D';
            break;
    }
    return letter;
}
