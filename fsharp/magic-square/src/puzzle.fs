namespace magic_square

module puzzle =

    let values : float list =
        [1.0; 1.5; 2.0; 2.5; 3.0; 3.5; 4.0; 4.5; 5.0]

    let magic_square (values : float list) : List<float list> =
        [
            [1.0; 1.5; 2.0]
            [2.5; 3.0; 3.5]
            [4.0; 4.5; 5.0]
        ]
