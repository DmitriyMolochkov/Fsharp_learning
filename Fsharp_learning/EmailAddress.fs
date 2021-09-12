module Fsharp_learning.EmailAddress

type T = EmailAddress of string

// wrap
let create (s: string) =
    if System.Text.RegularExpressions.Regex.IsMatch(s, @"^\S+@\S+\.\S+$") then
        Some(EmailAddress s)
    else
        None

// unwrap
let value (EmailAddress e) = e