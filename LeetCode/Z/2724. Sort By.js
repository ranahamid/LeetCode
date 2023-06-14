/**
 * @param {Array} arr
 * @param {Function} fn
 * @return {Array}
 */
var sortBy = (arr, fn) => arr.sort((a, b) => fn(a) - fn(b));

//https://leetcode.com/problems/sort-by/discuss/3624653/Full-thorough-explanation-or-bread