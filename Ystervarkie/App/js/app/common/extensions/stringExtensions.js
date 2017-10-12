(function () {
    'use strict';

    /**
     * Reports the index of the first occurrence in this instance of any character in a specified array of Unicode characters.
     * result = "hello world".indexOfAny([2, "hello", 5]);
     * trace( result ); // 0
     * 
     * result = "Five = 5".indexOfAny([2, "hello", 5]);
     * trace( result ) ; // 2
     * 
     * result = "action script is good".indexOfAny([2, "hello", 5]); 
     * trace( result ) ; // -1
     * @return the index of the first occurrence in this instance of any character in a specified array of Unicode characters.
    */
    String.prototype.indexOfAny =
        function (anyOf /*Array*/, startIndex /*uint*/, count /*int*/) { /*int*/
            startIndex = isNaN(startIndex) ? 0 : startIndex;
            if (startIndex < 0) {
                startIndex = 0;
            }

            count = isNaN(count) ? -1 : ((count >= 0) ? count : -1);

            if (anyOf != null && this != null && this !== "") {
                var i /*int*/;
                var l /*int*/ = anyOf.length;
                var endIndex /*int*/;
                if ((count < 0) || (count > l - startIndex)) {
                    endIndex = l - 1;
                } else {
                    endIndex = startIndex + count - 1;
                }
                for (i = startIndex; i <= endIndex; i++) {
                    if (this.indexOf(anyOf[i]) > -1) {
                        return i;
                    }
                }
            }
            return -1;
        };

    String.prototype.trunc = String.prototype.trunc ||
        function (n) {
            return (this.length > n) ? this.substr(0, n - 1) + '&hellip;' : this;
        };

    String.prototype.toCamelCase = function () {
        return this
            .replace(/\s(.)/g, function ($1) { return $1.toUpperCase(); })
            .replace(/\s/g, '')
            .replace(/^(.)/, function ($1) { return $1.toLowerCase(); });
    }

    String.prototype.toTitleCase = function () {
        return this.replace(/\w\S*/g, function (txt) { return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase(); });
    };
})();