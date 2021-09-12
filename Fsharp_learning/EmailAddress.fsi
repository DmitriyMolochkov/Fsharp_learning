module Fsharp_learning.EmailAddress

// encapsulated type
type T

// create with continuation
val createWithCont : success:(T -> 'a) -> failure:(string -> 'a) -> s:string -> 'a

// wrap
val create : string -> T option

// unwrap with continuation
val apply : f:(string -> 'a) -> T -> 'a

// unwrap
val value : T -> string