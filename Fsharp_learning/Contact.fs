module Fsharp_learning.Contact

open Fsharp_learning.EmailAddress
open Fsharp_learning.StateCode

type PersonalName =
    { FirstName: string
      MiddleInitial: string option
      LastName: string }

type EmailContactInfo =
    { EmailAddress: EmailAddress
      IsEmailVerified: bool }

type ZipCode = ZipCode of string

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