# tiny-maze

Alice found herself very tiny and wandering around Wonderland.  Even
the grass around her seemed like a maze.

![alice tiny](../../images/alicetiny.gif)

This is a tiny maze solver.

A maze is represented by a matrix

```fsharp
[ [    S; V(0); V(1) ]
  [ V(1); V(0); V(1) ]
  [ V(1); V(0);    E ] ]
```

- _S_ : start of the maze
- _E_ : end of the maze
- _V(1)_ : This is a wall that you cannot pass through
- _V(0)_ : A free space that you can move through.

The goal is the get to the end of the maze.  A solved maze will have a
_X_ in the start, the path, and the end of the maze, like this.

```fsharp
[ [    X; X; V(1) ]
  [ V(1); X; V(1) ]
  [ V(1); X;    X ] ]
```


## Instructions

- Clone, fork or degit this repo
- `cd csharp/tiny-maze/test`
- Run the tests with `dotnet test`
- Make the tests pass!

## Solutions

Once you have your kata solution, you are welcome to submit a link to your repo to share here in this section with others.


 
If you haven't solved your kata yet - Don't Peek!
