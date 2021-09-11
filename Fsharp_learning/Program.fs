open System
open Fsharp_learning
open Type

let from myType =
    sprintf $"from {myType.FirstName} {myType.Address1}"
    
[<EntryPoint>]
let main argv =
    let myType1 =
        { FirstName = "Dima"
          MiddleInitial = ""
          LastName = "Molochkov"
          EmailAddress = "molochkov.dima@mail.ru"
          IsEmailVerified = true
          Address1 = "Russian Federation"
          Address2 = "Russia"
          City = "Vladimir"
          State = "Central District"
          Zip = "600000"
          IsAddressValid = false }
        
    let myType2 = { myType1 with FirstName = "YMHUK"; LastName = "" }
        
    Console.WriteLine($"Hello world {from myType1}")
    printfn $"Hello world {from myType2}"
    0