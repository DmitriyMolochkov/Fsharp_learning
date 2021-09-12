module Fsharp_learning.StateCode

type StateCode = StateCode of string

// wrap
let create (s: string) =
    let s' = s.ToUpper()
    let stateCodes = [ "AZ"; "CA"; "NY"; "RU" ]

    if stateCodes |> List.exists ((=) s') then
        Some(StateCode s')
    else
        None

// unwrap
let value (StateCode s) = s
