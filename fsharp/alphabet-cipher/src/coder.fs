namespace alphabet_cipher

module coder =

    type Message = string
    type Keyword = string

    let encode (key : Keyword) (message : Message) : Message =
        "encodeme"

    let decode (key : Keyword) (message : Message) : Message =
        "decodeme"

    let decipher (cipher : Message) (message : Message) : Keyword =
        "decypherme"
