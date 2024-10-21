// simple function to sum values.
let soma x y =
    x + y

let val1 = System.Console.ReadLine()
let val2 = System.Console.ReadLine()
let x = int(val1)
let y = int(val2)
let resultado = soma x y

if resultado > 18 then 
    printfn "Success!"
else
    printfn "Result is not greater than 18!"