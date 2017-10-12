(function() {
    'use strict';

    Number.prototype.roundIt = function(precision) {
        var rounder = Math.pow(10, precision);
        return (Math.round(this * rounder) / rounder);
    };

})();