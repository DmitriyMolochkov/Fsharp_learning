open System
open Fsharp_learning
open Contact

let from contact =
    $"from %s{contact.Name.FirstName} from %s{contact.PostalContactInfo.Address.State}"

[<EntryPoint>]
let main argv =

    let contact =
        { Name = { FirstName = "Dima"; MiddleInitial = None; LastName = "Molochkov" }
          EmailContactInfo = { EmailAddress = "molochkov.dima@mail.ru"; IsEmailVerified = true }
          PostalContactInfo =
              { Address =
                    { Address1 = "Pushkin street house No. 15"
                      Address2 = "Apartment No. 33"
                      City = "Vladimir"
                      State = "Russian Federation"
                      Zip = "600001" }
                IsAddressValid = true } }

    printfn $"Hello world {from contact}"
    0