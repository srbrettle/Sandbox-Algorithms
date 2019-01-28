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

function vowelsAndConsonants(s) {
    let consonants = '';

    for (let i = 0; i < s.length; i++) {
        let letter = s.charAt(i);
        
        if (isVowel(letter)) {
            // log vowel
            console.log(letter)    
        }        
        else {
            consonants += s[i] + '\n';
        }
    }

    // log consonants
    console.log(consonants.trim());
}      

function isVowel(letter) {
    return /[aeiouAEIOU]/.test(letter);
}

