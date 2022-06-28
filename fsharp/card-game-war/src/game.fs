namespace card_game_war

module game =

    // feel free to use these cards or use your own data structure

    type Suit =
        | Spade
        | Club
        | Diamond
        | Heart

    type Rank =
        | Value of int
        | Jack
        | Queen
        | King
        | Ace

    type Card =
        { Suit : Suit; Rank : Rank }
        static member Create(suit : Suit, rank : Rank) =
            { Suit = suit; Rank = rank }

    (*
    let suits = [ Spade; Club; Diamond; Heart ]
    let heads = [ Jack; Queen; King; Ace ]

    let ranks =
        [   for v in 2 .. 10 -> Value v
            for head in heads -> head
        ]

    let deck =
        seq {
            for suit in suits do
                for rank in ranks -> Card.Create(suit, rank)
        }
    *)

    let playRound (player1_card : Card) (player2_card : Card) =
        raise <| System.NotImplementedException()

    let playGame (player1_cards : Card list) (player2_cards : Card list) =
        raise <| System.NotImplementedException()
