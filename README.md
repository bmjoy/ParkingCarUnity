# ParkingCarUnity
Project at university, using AI, a* algorithm to automatically find way or path to control parking car.

## FAQ
> ## Your first time clone this project? How to using this project in Unity?
> 1. Clone and open this project in Unity by add /RedHotSweetPepper folder of project into Unity Hub with 2019.4.28f1 Unity version installed
> 2. Chose "/prefabs folder is located in /assets folder" in project folder structure management in unity
> 3. Find Base 1 Object and drag into scene layout
> 4. Find Car 2 Object and drag into scene layout
> 5. Add Car 2 Object as element 0 for Spawner Object in scene layout, do this thing by select Spawer Object on the scene sctructure your will see all components of Spawer Object, at Spawner Script field, set size equal 1 if not, then drag Car 2 Object from scene sctructure or in /prefabs folder into Element 0 of Spawner Script field
> 6. Run project
> What this video tutorial:
<h3 align="center">
  <img width="200px" src="https://user-images.githubusercontent.com/55421234/122251554-ceb14c00-cef4-11eb-8f35-bdaea02b152b.mp4">
</h3>
> Class diagram:
<h3 align="center">
  <img width="200px" src="https://user-images.githubusercontent.com/55421234/122251821-0f10ca00-cef5-11eb-9dbd-a565983bf974.png">
</h3>

> ## Can i use multiple car object with others driving behavior?
> - Yes.
> - This how you do that:
> 1. Create Any Car Object you want with other color, size, component you want, add script if you want to control Object behavior
> 2. At Spawner Script field of Spawner Object, raise size to number type of Objects you want to extend and add your new custom Object in extended Element - it should be one type of Object per Element, if you want more, no problem, it just when get a random type of Object, the more Object of a specific type appear in list the more possibilities type of this Object appear in game

## This project has not reached the final stage yet, this project just supple some source code for people learn about some purposes:
> 1. How to using NavMesh 2D to find nearest way from point to point.
> 2. Working with list, array like append, remove element in array because it is not provided in Unity by default.
> 3. Work with Game Object and Life cycle of game object.
> 4. Work with basic Components and appear in most, in every Unity project like: Box collider, RigidBody, Script, NavMeshSurFace2d, NavMeshModifier, Using Tile,..
> 5. Drive a Object like car,.. with computer input.
> 6. Rotate a Object with degree.
> 7. Work with Vector2, Vector3, passing parameters from UI in to Object with [SerializeField] and still keep private property form.
> 8. How to get input from computer keyboard on runtime.

## References
> - ### Highly recommend try this first, it just 7 hour to know 80% about Unity, Others thing you shouuld do after watch this video it just practice to get pro at Unity :): [Basic about Unity programming in 7 hour](https://www.youtube.com/watch?v=gB1F9G0JXOo&list=LL&index=6&t=339s)
> - [Unity Library Documentation](https://docs.unity3d.com/Manual/index.html)
> - [How to use NavMesh 2D tutorial 1](https://www.youtube.com/watch?v=SDfEytEjb5o)
> - [How to use NavMesh 2D tutorial 2](https://www.youtube.com/watch?v=FK-Hn69X7P4)
> - [How to use NavMesh 3D tutorial 1](https://www.youtube.com/watch?v=CHV1ymlw-P8)
> - [How to use NavMesh 3D tutorial 2](https://www.youtube.com/watch?v=FkLJ45Pt-mY)
> - [How to use NavMesh 3D tutorial 3](https://www.youtube.com/watch?v=blPglabGueM&list=RDCMUCYbK_tjZ2OrIZFBvU6CCMiA&index=2)

