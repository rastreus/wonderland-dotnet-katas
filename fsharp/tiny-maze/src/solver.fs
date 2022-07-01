namespace tiny_maze

module solver =

    [<AutoOpen>]
    type P =
        | S
        | E
        | V of int
        | X

    let solve_maze (maze : List<P list>) : List<P list> =
        List.empty
