(function () {
    'use strict';

    Array.prototype.clean = function () {
        for (var i = 0; i < this.length; i++) {
            if (this[i] === undefined || this[i] === null || this[i].length === 0) {
                this.splice(i, 1);
                i--;
            }
        }
        return this;
    };

})();