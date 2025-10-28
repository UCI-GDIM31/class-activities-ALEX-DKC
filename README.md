# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.

### W2
1,Because color values use decimals between 0.0 and 1.0.
2£¬Because it counts how many times the ball bounces: 1, 2, 3
3£¬I add a ";"because it is the end of the sentence.

### W3
1, I belong to Table 5, and I will be answering question 1.
Q: You¡¯re building a rhythm game, and you¡¯re writing a method named DidPlayerHitBeat that tells you whether or not the player accurately hit a beat based on the time that they pressed a key.
The input will include float x and float y. Float x refers to the moment when player's finger touches the screen. Float y refers to the moment when player's finger leaves the screen. In the body part of the method, we will substract y from x to obtain float z. If z is greater than 0.2s, then bool whetherHit equals true. The boolean type whetherHit variable will be the output.
Input: float x (touch time); float y (leave time)
Output type: boolean

2,
Think of a class like a menu in a restaurant. The menu shows what kinds of dishes you can make.
when you use the class as a Component, it¡¯s like the chef cooking a real dish from that menu.
Member variables are like the ingredients of the dish ¡ª how spicy it is, how much sauce it has, or how big it is.
Methods are like the actions the chef does ¡ª mixing, frying, or boiling. They are what the dish can do.

3,
The balls become too bright because the color keeps getting multiplied again and again every time they bounce.When the number is too big, the ball looks extremely bright, just become white.

### W4

5	[SerializeField] private float _moveSpeed = 1.0f;
_moveSpeed is a number varaible, the type is flost and value is one, the value is showed it on the inpector and can be editted
22	float translation = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
the float varaible is translation, and value is Input.GetAxis("Vertical") which is a method call time movespeed time the time between frames.
25	transform.Translate(0, 0, translation);
This line is calling a method called Translate on the Transform component. The inputs parameters are 0, 0, and translation

1,What solution did you come up with for the collider activity, and why? Specifically- which objects did you add Rigidbodies to, and which object(s) did you check Is Trigger on?
Added Rigidbody to Cat and SoccerBall.
Checked Is Trigger on Goal so the ball can pass through but still trigger scoring.
Did not check Is Trigger on Cat, Ball to allow real collisions and bounces.

2,iF your game did not work perfectly the first time you tested it, talk about what you had to fix.
 Colliders were too big, so I resized them to match the objects.
the cat is rolling, froze X and Z rotation on the rigidbodies to keep them stable.

### W5
1, what exactly does gameObject refer to?
gameObject means the thing this script is attached to. Every script we write in Unity like Player, Enemy, CatW5 is a component that lives on a GameObject in our scene.

 transform.Translate means £¿
 move this object by some amount£¬move along the x, y, z axes

2,
varaible_moveSpeed is how fast the deer moves
Methods: Update() is a Unity method that runs every frame
it move the deer forward every frame by using transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime)



## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 