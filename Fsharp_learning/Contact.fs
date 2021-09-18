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
    
type PhoneContactInfo =
    { Phone: Phone.T
      IsPhoneValid: bool }
    
type ContactMethod =
    | Email of EmailContactInfo
    | PostalAddress of PostalContactInfo
    | HomePhone of PhoneContactInfo
    | WorkPhone of PhoneContactInfo

type ContactInfo = { ContactMethods : ContactMethod list }
    
type Contact =
    { Name: PersonalName
      ContactInfo: ContactInfo }