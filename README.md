# Reilly_Zink_3401week6

- Sprites are used to render flat 2D images
- Can be used as UI elements or gameplay elements
- To set an image asset as a sprite, select the image asset and change the Texture Type dropdown
in the inspector to “Sprite (2D and UI)”
- In the inspector, sprite assets can be packed via a tag; sprites with the same tag will be arranged
into the same texture sheet to save on memory
- Sprites dragged into the game scene will have different visible sizes based on the resolution of the
sprite asset
- If making a sprite-based game, be sure to create all sprites to a standard scale/resolution
- Sprites are rendered via the Sprite Renderer component
- The order in which sprites are drawn/layered can be changed in the Sprite Renderer component’s
“Order in Layer” field
- 2D physics in Unity use an entirely separate system from the 3D physics
- 2D physics exist in their own components
- 2D physics only act on the X/Y plane
- Rigidbody2Ds can have their gravity values individually tweaked
- Collider2Ds come in various primitive shapes, as well as Polygon Colliders, which can
automatically create a 2D collider in the shape of an imported sprite
- Like 3D colliders, 2D colliders can be set as triggers to respond to collision events
- You can respond to 2D physics/collision events in your scripts by implementing the
OnCollisionEnter2D and OnTriggerEnter2D functions
- The OnEnable () function is called on an object whenever it is enabled in the scene
- The return keyword can be used to immediately exit a function at that point
