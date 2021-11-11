function createMap(element, dotnetref, options) {

    if (typeof (options.map.defaultArea) !== 'undefined') {
        options.map.defaultArea.eventHandlers = {
            click: function (e, id, mapElem, textElem, elemOptions) {
                dotnetref.invokeMethodAsync('AreaClickHandler', id);

            }
        };
    }

    if (typeof (options.map.defaultPlot) !== 'undefined') {
        options.map.defaultPlot.eventHandlers = {
            click: function (e, id, mapElem, textElem, elemOptions) {
                dotnetref.invokeMethodAsync('PlotClickHandler', id);


            }
        };
    }

    $("#" + element).mapael(options);
}

