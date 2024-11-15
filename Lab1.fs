let rec product_of_odds n acc =
    if n <= 1 then
        acc
    else
        product_of_odds (n - 2) (acc * n)

let result = product_of_odds 13 3
printfn "%A" result
