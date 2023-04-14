/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function (nums, fn, init) {
    var answer = init;
    for (let i of nums) {
        answer = fn(answer, i);
    }
    return answer;
};