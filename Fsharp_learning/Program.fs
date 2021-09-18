open System
open Fsharp_learning
open Contact

let from contact =
    match contact.ContactInfo with
        | EmailOnly emailContactInfo ->
            $"from %s{contact.Name.FirstName}, my email is %s{emailContactInfo.EmailAddress |> EmailAddress.value}"
        | PostOnly postalContactInfo ->
            $"from %s{contact.Name.FirstName} from %s{postalContactInfo.Address.State |> StateCode.value}"
        | EmailAndPost (emailContactInfo, postalContactInfo) ->
            $"from %s{contact.Name.FirstName} from %s{postalContactInfo.Address.State |> StateCode.value}, my email is %s{emailContactInfo.EmailAddress |> EmailAddress.value}"
    
[<EntryPoint>]
let main argv =
    let createContact email =
        match (StateCode.create "RU") with
        | Some stateCode ->
            let contact =
                { Name =
                      { FirstName = "Dima"
                        MiddleInitial = None
                        LastName = "Molochkov" }
                  ContactInfo =
                      EmailAndPost(
                          { EmailAddress = email
                            IsEmailVerified = true },
                          { Address =
                                { Address1 = "Pushkin street house No. 15"
                                  Address2 = "Apartment No. 33"
                                  City = "Vladimir"
                                  State = stateCode
                                  Zip = ZipCode "600001" }
                            IsAddressValid = true }
                      ) }

            printfn $"Hello world {from contact}"
        | None -> ()
        
    let createError error =
        printfn $"Error %s{error}"
       
    
    EmailAddress.createWithCont createContact createError "molochkov.dima@mail.ru"

    0