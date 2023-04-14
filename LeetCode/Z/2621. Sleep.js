/**
 * @param {number} millis
 */
async function sleep(millis) {

    return new Promise(x => setTimeout(x, millis))
}

/** 
 * let t = Date.now()
 * sleep(100).then(() => console.log(Date.now() - t)) // 100
 */



async function sleep_2(millis) {

    await new Promise(x => setTimeout(x, millis))
}
