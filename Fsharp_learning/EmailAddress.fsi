﻿module Fsharp_learning.EmailAddress

// encapsulated type
type T

// wrap
val create : string -> T option

// unwrap
val value : T -> string