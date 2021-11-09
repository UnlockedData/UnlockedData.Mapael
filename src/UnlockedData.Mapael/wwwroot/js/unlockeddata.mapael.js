

//UnlockedData Interop Code

function createMap(element, dotnetref, options) {    
    
    if (typeof(options.map.defaultArea) !== 'undefined') {
        options.map.defaultArea.eventHandlers = {
            click: function (e,id,mapElem,textElem,elemOptions) {                
                dotnetref.invokeMethodAsync('ClickHandler',id);
                
                console.log(id);
                console.log(mapElem);
                console.log(textElem);
                console.log(elemOptions);
            }};
    }

    if (typeof(options.map.defaultPlot) !== 'undefined') {
        options.map.defaultPlot.eventHandlers = {
            click: function (e,id,mapElem,textElem,elemOptions) {
                dotnetref.invokeMethodAsync('ClickHandler',id);

              
            }};
    }


    // options.defaultPlot.eventHandlers = {
    //     click: function (e,id,mapElem,textElem,elemOptions) {
    //         console.log(e);
    //         console.log(id);
    //         console.log(mapElem);
    //         console.log(textElem);
    //         console.log(elemOptions);
    //     }};


    $("#"+element).mapael(options);
}

