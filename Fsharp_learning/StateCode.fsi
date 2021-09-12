module Fsharp_learning.StateCode

// encapsulated type
type T

// wrap
val create : string -> T option

// unwrap
val value : T -> string