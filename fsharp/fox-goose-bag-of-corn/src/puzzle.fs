namespace fox_goose_bag_of_corn

module puzzle =

    [<AutoOpen>]
    type Puzzle =
        | Fox
        | Goose
        | Corn
        | You
        | Boat

    let start_pos =
        [
            [[Fox; Goose; Corn; You]; [Boat]; []]
        ]

    let river_crossing_plan () =
        start_pos
