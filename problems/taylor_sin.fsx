// sin (x) taylor series
let x= 10
let n= 10
let mutable sum = x

let rec fatorial n =
    match n with
    | 0 -> 1
    | _ -> n * fatorial (n - 1)

// definition of power function
let pow (a:float) (b:int) :float=
    let mutable c:float = 1
    for i = 1 to b do
        c <- c * a
    c

let sinTaylor x n =
    let mutable sum: double = x
    for i = 1 to n-1 do
        sum <- sum + pow -1 i * pow x (2*i+1) / float (fatorial (2*i+1))
    sum

printfn "%f" (sinTaylor 2 6)
