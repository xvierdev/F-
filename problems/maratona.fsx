// unoptimized programming marathon
let x:float = 5.0 * 3.1415 / 180.0
let n = 6
let mutable soma: float = 1.0

// define fatorial function
let rec fatorial (a:float):float=
    match a with
    | 0.0 -> 1.0
    | _ -> a * fatorial (a - 1.0)

// define power function
let rec pow (a:float) (b: int):float=
    match b with
    | 0 -> 1
    | _ -> a * pow a (b - 1)


for i = 1 to n - 1 do
    let k: float = float i
    soma <- soma + (pow -1 i) * pow x (2*i) / fatorial (2.0 * k)

printfn "%f" soma