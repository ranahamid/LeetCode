/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function (init) {
    var result = init;
    function increment() {
        result++;
        return result;
    }
    function decrement() {
        result--;
        return result;
    }
    function reset() {
        result = init;
        return result;
    }
    return {
        increment,
        decrement,
        reset
    };
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */