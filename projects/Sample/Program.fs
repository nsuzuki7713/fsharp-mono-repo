// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let add x y= x * y 

let squarePlusOne x = 
  let square = x * x 
  square + 1

let a = squarePlusOne 3

let areEqual x y = (x = y)

type ProductCode =
| ProductCode of string

type Person = {First:string; Last:string}

let aPerson = {First="Alex"; Last="Adams"}
let {First=first; Last=last} = aPerson


type OrderQuantity =
| UnitQuantity of int
| KilogramQuantity of float

let anOrderQtyInUnits = UnitQuantity 10
let anOrderQtyInKg = KilogramQuantity 2.5


type CheckNumber = CheckNumber of int
type CardNumber = CardNumber of string

type CardType = Visa | Mastercard
type CreditCardInfo = { 
  CardType : CardType
  CardNumber : CardNumber
}

type PaymentMethod = 
  | Cash
  | Check of CheckNumber
  | Card of CreditCardInfo

type PaymentAmount = PaymentAmount of decimal
type Currency = EUR | USD

type Payment = {
  Amount : PaymentAmount 
  Currency: Currency 
  Method: PaymentMethod 
}

type Option<'a> = 
  | Some of 'a
  | None

type CustomerId =
| CustomerId of int

// type CustomerId2 = CustomerId of int

let customerId = CustomerId 42

type b = {
  a: int
  b: string
}

type c = 
  | A of int
  | B of string

type UnvalidatedOrder = UnvalidatedOrder of int
type ValidatedOrder = ValidatedOrder of int
type ValidateOrder = UnvalidatedOrder-> ValidatedOrder