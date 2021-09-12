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

type Contact =
    { Name: PersonalName
      EmailContactInfo: EmailContactInfo
      PostalContactInfo: PostalContactInfo }