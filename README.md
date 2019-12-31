# MITHC-ARtests
preliminary experiments with AR in Unreal for REMAP MITHC project

Builds upon Unreal's starter AR template to 
* hide/show object using Actor tags and debug menu button 
  
* trigger crossfade sequence of material opacity
  
## Hide/Show Object
1. copied starter blueprint BP_Placeable to create BP_PlaceableSphere and BP_PlaceableCone
  
2. under details of the Asset add Actor Tags, (Shape and Sphere or Cone)
  
3. update apps hit detection mechanism in BP_ARPawn to spawn custom Placeable objects instead of default randomized shapes
  
4. add buttons to debug menu for toggling visibility of cones and spheres
  
  - create function attached to button that updates a visibility boolean and text on the button
 
 ![Example Toggle Visibility Function](https://github.com/daricalouie/MITHC-ARtests/blob/master/images/toggleConesFN.JPG)
    
  - attached to debug menu's event tick pull from the visibility boolean, use Get All Actors with Tag and For Loop to Set Actor Hidden in Game according to boolean

 ![Example GetAllActors and Hide Event Graph](https://github.com/daricalouie/MITHC-ARtests/blob/master/images/showConesGraph.JPG)

## Crossfade Sequence
1. create a scalar Material Parameter Collection
  
2. plug it into opacity of material you are using
  
3. create a level sequence that changes Material Parameter Collection scalar from 1 to 0
  
4. create level sequence player, drag Play Blueprint out of Exec and connect Out Actor as target

![Example Sequence Player](https://github.com/daricalouie/MITHC-ARtests/blob/master/images/sequencePlayer.JPG)

