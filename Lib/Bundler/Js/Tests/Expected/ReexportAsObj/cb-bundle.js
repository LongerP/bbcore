!function(undefined) {
    "use strict";
    function fn(a, b) {
        return a + b;
    }
    console.log({
        fn: fn
    }.fn(1, 2));
}();