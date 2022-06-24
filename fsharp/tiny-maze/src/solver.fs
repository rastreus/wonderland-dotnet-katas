namespace tiny_maze

module solver =

    [<AutoOpen>]
    type Maze =
        | S
        | E
        | V of int
        | X

    let solve_maze (maze : List<Maze list>) : List<Maze list> =
        List.empty
