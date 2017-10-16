var map = {};
var p = 0;

/**
 * Encodes a URL to a shortened URL.
 *
 * @param {string} longUrl
 * @return {string}
 */
var encode = function(longUrl) {
    map[p] = longUrl;
    const hash = Buffer.alloc(4);
    hash.writeUInt32BE(p, 0);
    p++;
    return 'https://ekyu.io/' + hash.toString('base64');
};

/**
 * Decodes a shortened URL to its original URL.
 *
 * @param {string} shortUrl
 * @return {string}
 */
var decode = function(shortUrl) {
    const hash = Buffer.from(shortUrl.slice(16), 'base64').readUInt32BE(0);
    return map[hash];
};

/**
 * Your functions will be called as such:
 * decode(encode(url));
 */