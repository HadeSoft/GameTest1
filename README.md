# GameTest1

## Interface Functions

- CreateRoom(size, name) : create room to place objects in
  - PlaceObject(objectName, position) : place defined object
  
- DefineObject(name, script?) : define placeable object

- `OBJECT` : Object properties
  - Position / Position [get, set] : Position of object
  - Size / Dimension [get, set] : Size of object
  - Sprite / Texture2D [get] : 2D texture of object
  - Parent / Object [get] : Object to follow
  - SetSprite(path) : Tell the object where to look for its sprite
  - Event_KeyPress(key, func?) : define event activated on keypress
  - Event_Init(func) : define event activated on object initialisation
  - Event_Draw(func) : define event activated when object is drawn
  - Event_PhysicUpdate(func) : define event activated on each physic frame
  - Event_DrawUpdate(func) : define event activated on each draw frame
  - Event_Destory(func) : define event activated when object is destoryed
  - Event_Removed(func) : define event activated when object is removed from it's parent room
  - ChildOf(object) : Cause the object to set position relative to parent object
  - Add_Physics() : add physics to object
  
  - `BODY` : Physics properties
    - Weight / float [get, set] : Body's weight when interacting with graivty
    - Gravity / float [get, set] : Body's gavity effect on other bodies
    - Static / boolean [get, set] : Whether or not the Body is effected by gravity
    - Make_Solid() : add a rigid frame to physics body
    
    - `FRAME` : Solid body properties
      - Size / Dimension [get, set] : Dimension of frame around body
      - Origin / Position [get, set] : Initial position for frame
      - Friction / float [get, set] : Set friction between frames
      - Event_Collision(func) : define event activated on collision with a frame
      - Event_Collision_With(objType, func) : define event activated on collision with a set object type
      - CollideWith(GroupMask) : set a list of objects to collide with
  
## World Structure

- `World` : Grouping of rooms
  - List of rooms in world
  - Different worlds for different states of the game e.g. world for main menu, world for a match
- `Room` : A visible play area to place objects in
  - List of objects to place when initiated
  - Spawn points for players
  - Layers / ArrayList(RoomLayer) : Array of layers, drawing layer 0 first ... layer 'n' last
- `View` : Object/Text Drawn directly onto the camera
  - GUI / HUD
  - Menus

## Misc. Class List
- `Position` : double x, double y [get] [set]
- `Dimension` : double height, double width, double rotation(degrees)? [get] [set]
- `RoomLayer` : Seperate layers for sprites to be drawn on
- `GroupMask` : Group of Objects or RoomLayers to colide with
- `SpawnPoint` : Creation point for Objects in a Room

## Error Classes
- `InvalidRoomException` : Error when creating room, values not correctly set
