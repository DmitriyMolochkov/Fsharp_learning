open System
open Fsharp_learning
open Contact

let printContactMethod cm =
    match cm with
    | Email emailAddress -> printfn $"Email Address is %s{emailAddress.EmailAddress |> EmailAddress.value}"
    | PostalAddress postalAddress -> printfn $"Postal Address is %s{postalAddress.Address.Address1}"
    | HomePhone phoneNumber -> printfn $"Home Phone is %s{phoneNumber.Phone |> Phone.value}"
    | WorkPhone phoneNumber -> printfn $"Work Phone is %s{phoneNumber.Phone |> Phone.value}"

let printReport contactInfo =
    let { ContactMethods = methods } = contactInfo
    methods |> List.iter printContactMethod

let from contact =
        $"from %s{contact.Name.FirstName}"

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
                      { ContactMethods =
                            [ Email(
                                { EmailAddress = email
                                  IsEmailVerified = true }
                              )
                              PostalAddress(
                                  { Address =
                                        { Address1 = "Pushkin street house No. 15"
                                          Address2 = "Apartment No. 33"
                                          City = "Vladimir"
                                          State = stateCode
                                          Zip = ZipCode "600001" }
                                    IsAddressValid = true }
                              )
                              HomePhone(
                                  { Phone = (Phone.create "88005553535").Value
                                    IsPhoneValid = false }
                              ) ] } }
            printfn $"Hello world {from contact}"
            printReport contact.ContactInfo
        | None -> ()

    let createError error = printfn $"Error %s{error}"

    EmailAddress.createWithCont createContact createError "molochkov.dima@mail.ru"
    0