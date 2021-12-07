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

    if (typeof (options.map.defaultLink) !== 'undefined') {
        options.map.defaultLink.eventHandlers = {
            click: function (e, id, mapElem, textElem, elemOptions) {
                dotnetref.invokeMethodAsync('LinkClickHandler', id);
            }
        };
    }

    $("#" + element).mapael(options);
}

function updateMap(element, dotnetref, options) {
    let data = $("#" + element).data().mapael;
    
    $("#"+element).trigger('update', [{
        deletePlotKeys: Object.keys(data.plots ),
        deleteLinkKeys: Object.keys(data.links ),
        animDuration: 500
    }]);
    $("#"+element).trigger('update', [{
        newPlots : options.plots,
        newLinks : options.links,
        animDuration: 500
    }]);
}