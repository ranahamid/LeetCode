/**
 * @param {Object | Array} obj
 * @return {boolean}
 */
var isEmpty = function (obj) {

    if (Array.isArray(obj)) {
        return obj.length === 0;
    }
    else if (typeof obj === 'object' && obj !== null) {
        return Object.keys(obj).length === 0;
    }
    return false; // not an object or array

};



/**
 * @param {Object | Array} obj
 * @return {boolean}
 */
var isEmpty = function (obj) {

    for (var a in obj)
        return false;
    return true;

};