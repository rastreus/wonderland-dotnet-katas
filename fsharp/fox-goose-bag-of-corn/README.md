# fox-goose-bag-of-corn

One of Lewis Carroll's favorite puzzles to ask children was the one
about the _Fox, Goose, and Bag of Corn_.  It has to do with getting
them all safely across a river.

![alice swimming](../../images/storytelling.gif)


The rules for this puzzle are:

- You must get the fox, goose, and bag of corn safely across the other side of the river
- You can only carry 1 item on the boat across with you.
- The fox cannot be left alone with the goose, (or it will be eaten).
- The goose cannot be left alone with the corn, (or it will be eaten).

The data structure to represent this puzzle is a list of lists.

The starting position is you, the fox, the goose, and corn on one side of the river. The boat is empty. The other river bank is empty.

```fsharp
[ [[fox; goose; corn; you]; [boat]; []] ]
```

You could take the corn on the boat with you

```fsharp
[ [[Fox; Goose; Corn; You]; [Boat]; []]
  [[Fox; Goose]; [Boat; Corn; You]; []] ]
```

But then the fox would eat the goose!

The goal is to have the plan in steps so that all make it safely to the other side

```
[ [[Fox; Goose; Corn; You]; [Boat]; []]
  ...
  [[[] [Boat] [Fox; Goose; Corn; You]]] ]
```

## Instructions

- Clone, fork or degit this repo
- `cd fox-goose-bag-of-corn`
- Run the tests with `dotnet test`
- Make the tests pass!

## Solutions

Once you have your kata solution, you are welcome to submit a link to your repo to share here in this section with others.



If you haven't solved your kata yet - Don't Peek!
