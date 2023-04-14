/**
 * @param {number} n
 * @return {Function} counter
 */
var createCounter = function (n) {
    let counter = n;

    return function () {
        var current = counter;
        counter++;
        return current;
    };
};

/** 
 * const counter = createCounter(10)
 * counter() // 10
 * counter() // 11
 * counter() // 12
 */