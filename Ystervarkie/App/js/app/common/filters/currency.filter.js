(function () {
    'use strict';

    angular
        .module('yvApp.common')
        .filter('currency', currency);

    /*@ngInject*/
    function currency(appConfig, $filter) {
        return function (input, curSymbol, decPlaces, thouSep, decSep) {
            //var objCurSymbol = curSymbol.trim() || appConfig.defaultCurrency;
            var objCurSymbol = curSymbol;
            var objDecPlaces = decPlaces || 2;
            var objThouSep = thouSep || ",";
            var objDecSep = decSep || ".";

            // Check for invalid inputs
            var out = isNaN(input) || input === '' || input === null ? 0.0 : input;

            //Deal with the minus (negative numbers)
            var minus = input < 0;
            out = Math.abs(out);
            out = $filter('number')(out, objDecPlaces);

            // Replace the thousand and decimal separators.  
            // This is a two step process to avoid overlaps between the two
            if (objThouSep !== ",") out = out.replace(/\,/g, "T");
            if (objDecSep !== ".") out = out.replace(/\./g, "D");
            out = out.replace(/T/g, objThouSep);
            out = out.replace(/D/g, objDecSep);

            // Add the minus and the symbol
            if (minus) {
                return "-" + objCurSymbol + ' ' + out;
            } else {
                return objCurSymbol + ' ' + out;
            }
        };
    }
})();