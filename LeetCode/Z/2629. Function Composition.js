/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function (functions) {

    if (functions.length === 0) { // If the array of functions is empty
        return function (x) { return x; }; // Return the identity function
    }

    return function (x) {
        let result = x;
        for (let i = functions.length - 1; i >= 0; i--) {
            result = functions[i](result);
        }
        return result;
    }
};

/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */