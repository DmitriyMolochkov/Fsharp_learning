open System
open Fsharp_learning
open Contact
open Microsoft.FSharp.Reflection

let from contact =
    let (StateCode code) = contact.PostalContactInfo.Address.State
    //$"from %s{contact.Name.FirstName} from %s{match contact.PostalContactInfo.Address.State with |StateCode code -> code}"
    $"from %s{contact.Name.FirstName} from %s{code}"
    


[<EntryPoint>]
let main argv =
    match (CreateEmailAddress "molochkov.dima@mail.ru") with
    | Success email ->
        match (CreateStateCode "RU") with
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
    | Error error -> printfn $"Error: %s{error}"
    0