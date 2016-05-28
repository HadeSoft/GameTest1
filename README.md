# GameTest1

## Interface Functions

- CreateRoom(size, name) : create room to place objects in
  - PlaceObject(objectName, position) : place defined object
  
- DefineObject(name, script?) : define placeable object

- <OBJECT> : Object properties
  - Position / Position [get, set] : Position of object
  - Size / Dimension [get, set] : Size of object
  - Sprite / Texture2D [get] : 2D texture of object
  - SetSprite(path) : Tell the object where to look for its sprite
  - Event_KeyPress(key, func?) : define event activated on keypress
  - Event_Init(func) : define event activated on object initialisation
  - Event_Draw(func) : define event activated when object is drawn
  - Event_PhysicUpdate(func) : define event activated on each physic frame
  - Event_DrawUpdate(func) : define event activated on each draw frame
  - Event_Destory(func) : define event activated when object is destoryed
  - Event_Removed(func) : define event activated when object is removed from it's parent room
  - Add_Physics() : add physics to object
  
  - <BODY> : Physics properties
    - Weight / float [get, set] : Body's weight when interacting with graivty
    - Gravity / float [get, set] : Body's gavity effect on other bodies
    - Static / boolean [get, set] : Whether or not the Body is effected by gravity
    - Make_Solid() : add a rigid frame to physics body
    
    - <FRAME> : Solid body properties
      - Size / Dimension [get, set] : Dimension of frame around body
      - Origin / Position [get, set] : Initial position for frame
      - Friction / float [get, set] : Set friction between frames
      - Event_Collision(func) : define event activated on collision with a frame
      - Event_Collision_With(objType, func) : define event activated on collision with a set object type
      - CollideWith(collisionMask) : set a list of objects to collide with
  
