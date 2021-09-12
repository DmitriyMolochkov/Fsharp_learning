open System
open Fsharp_learning
open Contact

let from contact =
    $"from %s{contact.Name.FirstName} from %s{contact.PostalContactInfo.Address.State |> StateCode.value}"
    
[<EntryPoint>]
let main argv =
    match (EmailAddress.create "molochkov.dima@mail.ru") with
    | Some email ->
        match (StateCode.create "RU") with
        | Some stateCode ->
            let contact =
                { Name = { FirstName = "Dima"; MiddleInitial = None; LastName = "Molochkov" }
                  EmailContactInfo = { EmailAddress = email; IsEmailVerified = true }
                  PostalContactInfo =
                      { Address =
                            { Address1 = "Pushkin street house No. 15"
                              Address2 = "Apartment No. 33"
                              City = "Vladimir"
                              State = stateCode
                              Zip = ZipCode "600001"  }
                        IsAddressValid = true } }
            printfn $"Hello world {from contact}"
        | None -> ()
    | None -> ()
    0