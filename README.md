# UnlockedData.Mapael

A Blazor implementation of the mapping library [Jquery Mapael](https://www.vincentbroute.fr/mapael/) by [Vincent Brouté](https://github.com/neveldo) with a dynamic slice generator for on-the-fly data visualisation (albeit rudimentary providing just linear size for now)

The main dependencies outside of Jquery have been bundled with the package for convenience. Everything is managed in the old Blazor way for now, it will move to isolated JS at some point.

Contributions are welcome - PRs for missing features (event handling, proper update handling, js modularisation, more slice generators) will happily be accepted if working

[![ci-build](https://github.com/UnlockedData/UnlockedData.Mapael/actions/workflows/ci-build.yml/badge.svg)](https://github.com/UnlockedData/UnlockedData.Mapael/actions/workflows/ci-build.yml)

## Setup

For client-side and server-side Blazor - add the below script sections (and optional css) to index.html or _Host.cshtml/_Layout.cshtml 

```xml
   <link href="_content/UnlockedData.Mapael/mapael.css" rel="stylesheet"/>
   
   .....   
   
   <script src="_content/UnlockedData.Mapael/js/mapael.dependencies.js"></script>
   <script src="_content/UnlockedData.Mapael/js/mapael.js"></script>
   <script src="_content/UnlockedData.Mapael/js/unlockeddata.mapael.js"></script>    
```

For maps to render, you must provide the SVG data. Some are bundled with the library as they were used to make the demo. If you want to use your own map, you certainly can by following the guide [here](https://www.vincentbroute.fr/mapael/create-map.php)

```xml

   <script src="_content/UnlockedData.Mapael/js/maps/world_countries_miller.js"></script>
   <script src="_content/UnlockedData.Mapael/js/maps/france_departments.js"></script>
```

To put a simple map on the page, add the following component

```xml

<Mapael />

```
Some basic examples are bundled in the demo solution (direct copies of examples provided with the original library).

## Release Notes

### What's New

Link lines to join points. A new page showing example usage is included in the demo.

### Known Issues

A PR for a much needed feature in relation to scaling plots on zoom was applied to the library. There is a known issue detailed here in the [original PR](https://github.com/neveldo/jQuery-Mapael/pull/352), it was applied because it can be easily worked around by not using strokes on plots

### Bug Fixes

None

