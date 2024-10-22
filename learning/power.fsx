let rec power (a:float) (b:int):float =
    match b with
    | 0 -> 1
    | _ -> a * power a (b-1)

printfn "%f" (power 2 12)