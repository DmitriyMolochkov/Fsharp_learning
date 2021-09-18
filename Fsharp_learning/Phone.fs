module Fsharp_learning.Phone

type T = Phone of string

// create with continuation
let createWithCont success failure (s: string) =
    if System.Text.RegularExpressions.Regex.IsMatch(s, @"^[0-9]{6,15}$") then
        success (Phone s)
    else
        failure "Phone must contain only numbers and be 6 to 15 characters long"

// create directly
let create s =
    let success e = Some e
    let failure _ = None
    createWithCont success failure s

// unwrap with continuation
let apply f (Phone e) = f e

// unwrap directly
let value e = apply id e

