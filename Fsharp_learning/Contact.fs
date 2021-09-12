module Fsharp_learning.Contact

type PersonalName =
    { FirstName: string
      MiddleInitial: string option
      LastName: string }

type EmailAddress = EmailAddress of string

type EmailContactInfo =
    { EmailAddress: EmailAddress
      IsEmailVerified: bool }

type ZipCode = ZipCode of string
type StateCode = StateCode of string

type PostalAddress =
    { Address1: string
      Address2: string
      City: string
      State: StateCode
      Zip: ZipCode }

type PostalContactInfo =
    { Address: PostalAddress
      IsAddressValid: bool }

type Contact =
    { Name: PersonalName
      EmailContactInfo: EmailContactInfo
      PostalContactInfo: PostalContactInfo }
    
type CreationResult<'T> = Success of 'T | Error of string

let success e = Success e
let failure er  = Error er

let CreateEmailAddress (s:string) =
    if System.Text.RegularExpressions.Regex.IsMatch(s,@"^\S+@\S+\.\S+$")
    then success (EmailAddress s)
    else failure "Email address must contain an @ sign"

let CreateStateCode (s: string) =
    let s' = s.ToUpper()
    let stateCodes = ["AZ"; "CA"; "NY"; "RU"]
    if stateCodes |> List.exists ((=) s')
    then Some (StateCode s')
    else None