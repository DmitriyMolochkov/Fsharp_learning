module Fsharp_learning.Contact

type PersonalName =
    { FirstName: string
      MiddleInitial: string option
      LastName: string }

type EmailContactInfo =
    { EmailAddress: EmailAddress.T
      IsEmailVerified: bool }

type ZipCode = ZipCode of string

type PostalAddress =
    { Address1: string
      Address2: string
      City: string
      State: StateCode.T
      Zip: ZipCode }

type PostalContactInfo =
    { Address: PostalAddress
      IsAddressValid: bool }
    
type ContactInfo =
    | EmailOnly of EmailContactInfo
    | PostOnly of PostalContactInfo
    | EmailAndPost of EmailContactInfo * PostalContactInfo

type Contact =
    { Name: PersonalName
      ContactInfo: ContactInfo }