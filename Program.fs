
// Question2

let rec product_tail_recursive (lst: int list) (acc: int) =
    if lst.IsEmpty then
        acc
    else
        product_tail_recursive lst.Tail (acc * lst.Head)

let numbers = [6; 7; 8; 9; 10]
let result = product_tail_recursive numbers 1
printfn "%A" result


// // Question3

// let rec product_of_odds n acc =
//     if n <= 1 then
//         acc
//     else
//         product_of_odds (n - 2) (acc * n)

// let result = product_of_odds 13 3
// printfn "%A" result

// // Question4
// let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
// let trimmedNames = names |> List.map (fun name -> name.Trim())
// printfn "%A" trimmedNames


// // Question 5
// let f = fun x -> x % 3 = 0 && x % 4 = 0
// let numbers = Seq.init 450 (fun x -> x + 1)
// let filteredNumbers = numbers |> Seq.filter f
// let sumFiltered = filteredNumbers |> Seq.fold (+) 0
// printfn "%A" sumFiltered



// let f : string -> bool = fun s -> s.Contains("I", System.StringComparison.OrdinalIgnoreCase)
// let names : string list = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
// let filteredNames : string list = names |> List.filter f
// let concatenatedNames : string = filteredNames |> List.fold (fun acc name -> acc + name) ""

// printfn "%s" concatenatedNames
